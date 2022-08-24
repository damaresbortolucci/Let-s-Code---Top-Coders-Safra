using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MakeupStoreApi.Dtos;
using MakeupStoreApi.Models;


namespace MakeupStoreApi.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }



        //API usada como base "https://makeup-api.herokuapp.com/"


        //BUSCA PAGINADA por product_type
        //EX: blush, bronzer, lipstick, eyebrow, nail_polish, mascara, foundation

        [HttpGet("type")]
        public ActionResult<IEnumerable<Product>> Get([FromQuery] string type, [FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var data = AccessDb.GetData();

            if (!string.IsNullOrWhiteSpace(type))
            {
                var filteredData = data
                    .Where(x => x.product_type == type)
                    .OrderBy(x=>x.brand)
                    .ThenBy(x=>x.id)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize).ToList();
                return Ok(filteredData);
            }

            var result = data
                .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

            return Ok(new
            {
                StatusCode = 200,
                Message = "Consulta bem sucedida",
                Meta = new
                {
                    CurrentPage = page,
                    PageSize = pageSize
                },
                Data = result
            });
        }



        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var data = AccessDb.GetData();

            var filteredData = data
                .Where(x => x.id == id)
                .FirstOrDefault();

            if (filteredData == null)
            {
                return NotFound(new
                {
                    message = "ID não encontrado"
                });
            }
            return Ok(filteredData);
        }


        //Busca todas as marcas e o total de produtos em cada uma
        [HttpGet("allBrands")]
        public ActionResult<List<string>> GetAllBrands()
        {
            var data = AccessDb.GetData();

            var filteredData = data
                .Where(x => x.brand != null)
                .OrderBy(x=>x.brand)
                .GroupBy(x => x.brand)
                .Select(x => new
                {
                    Marca = x.Key,
                    Total_Produtos = x.Key.Count()
                })
                .ToList();

            return Ok(filteredData);
        }


        //busca por marca específica
        // EX: maybelline, nyx, l'oreal, milani, revlon

        [HttpGet("brand")]
        public ActionResult<IEnumerable<Product>> GetByBrandName([FromQuery] string brand)
        {
            var data = AccessDb.GetData();

            if (string.IsNullOrWhiteSpace(brand))
            {
                var brandToLower = brand.ToLower();
                var filteredData = data
                    .Where(x => x.brand == brandToLower)
                    .OrderBy(x => x.id)
                    .ToList();

                return Ok(filteredData);
            }

           return NotFound(new
                {
                    message = "Marca não encontrada"
                });
        }




        [HttpPost]
        public object Create([FromBody] ProductDto prod)
        {
            var data = AccessDb.GetData();
            var lastId = data.OrderBy(p => p.id).Last().id + 1;

            var newProduct = new Product
            {
                id = lastId,
                brand = prod.brand,
                name = prod.name,
                price = prod.price,
                image_link = prod.image_link,
                description = prod.description,
                rating = prod.rating,
                category = prod.category,
                product_type = prod.product_type,
                tag_list = prod.tag_list
            };

            data.Add(newProduct);
            var content = JsonSerializer.Serialize(data);
            System.IO.File.WriteAllText("./data.json", content);

            return Created($"https://localhost:44332/users/{lastId}", newProduct);
        }




        [HttpPut]
        public ActionResult<Product> Update(int id, [FromBody] ProductDto prod)
        {
            var data = AccessDb.GetData();
            var productToUpdate = data.SingleOrDefault(p => p.id == id);

            if (productToUpdate == null)
                return NotFound("ID não localizado");


            productToUpdate.brand = prod.brand;
            productToUpdate.name = prod.name;
            productToUpdate.price = prod.price;
            productToUpdate.image_link = prod.image_link;
            productToUpdate.description = prod.description;
            productToUpdate.rating = prod.rating;
            productToUpdate.category = prod.category;
            productToUpdate.product_type = prod.product_type;
            productToUpdate.tag_list = prod.tag_list;

            var content = JsonSerializer.Serialize(data);
            System.IO.File.WriteAllText("./data.json", content);

            return Ok("Produto atualizado");
        }



        [HttpDelete("id")]
        public ActionResult<string> Delete(int id)
        {
            var data = AccessDb.GetData();
            var productoToDelete = data.Where(p => p.id == id).FirstOrDefault();

            if (productoToDelete == null)
                return NotFound("ID não localizado");

            if (data.Remove(productoToDelete))
            {
                var content = JsonSerializer.Serialize(data);
                System.IO.File.WriteAllText("./data.json", content);
                return Ok("Exclusão bem sucedida");
            }
            return BadRequest("Houve um erro e o produto não foi excluído.");
        }
    }
}