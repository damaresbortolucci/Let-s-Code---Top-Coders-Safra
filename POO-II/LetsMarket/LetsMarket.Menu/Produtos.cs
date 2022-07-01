using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMarket.Menu
{
    public class Produtos
    {
        public static Action ListarProdutos = () => Console.WriteLine("Listando Produtos");
        public static Action CadastrarProdutos = () => Console.WriteLine("Cadastrando Produtos");
    }
}
