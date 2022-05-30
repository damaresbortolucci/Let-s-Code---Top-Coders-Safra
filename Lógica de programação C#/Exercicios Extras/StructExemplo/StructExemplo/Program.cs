using System.Globalization;
public class Program
{
    public static void Main()
    {
        Product mouse = new Product(1, "Mouse Gamer", 149.99, EProductType.Product);
        Product manutencao = new Product(2, "Manutenção de Computador", 250.00, EProductType.Service);

        var en = CultureInfo.CreateSpecificCulture("en-US");

        Console.WriteLine($"Id: {mouse.Id}");
        Console.WriteLine($"Produto: {mouse.Name}");
        Console.WriteLine($"Preço: {mouse.Price:C}");
        Console.WriteLine($"Preço em dólar: {mouse.PriceInDolar(4.77).ToString("C",en)}");
        Console.WriteLine($"Tipo n°: {(int)mouse.Type}"); //imprime o valor numérico do tipo
        Console.WriteLine($"Tipo: {mouse.Type}"); //imprime o nome do tipo

        Console.WriteLine("-----------------------------------");

        Console.WriteLine($"Id: {manutencao.Id}");
        Console.WriteLine($"Produto: {manutencao.Name}");
        Console.WriteLine($"Preço: {manutencao.Price:C}");
        Console.WriteLine($"Preço em dólar: {manutencao.PriceInDolar(4.77).ToString("C",en)}");
        Console.WriteLine($"Tipo n°: {(int)manutencao.Type}");
        Console.WriteLine($"Tipo: {manutencao.Type}");

    }


    //Struct e Enum -> sempre cria fora da main

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolar)
        {
            return Price / dolar;
        }
    }


    //Substituem o uso de inteiros
    //Usados em listas curtas
    //Usados em dados fixos
    //Começa com a letra E
    //Sempre em maiúsculo
    enum EProductType
    {
        Product = 1, //separa com ","
        Service = 2
    }
}
