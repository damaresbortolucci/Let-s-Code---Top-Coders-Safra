using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMarket.Menu
{
    public class Funcionarios
    {


        public static Action ListarFuncionarios = () => Console.WriteLine("Listando Funcionário");
        public static Action CadastrarFuncionarios = () => Console.WriteLine("Cadastrando Funcionário");
    }
}
