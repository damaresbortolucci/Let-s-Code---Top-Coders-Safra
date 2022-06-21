using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_POO_Desafios
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {

            //2 - Em uma escola, além dos alunos temos os funcionários, que tambémprecisam ser representados em nossa aplicação.
            //Então crie uma classe chamada Funcionario que contenha dois atributos: o primeiro para o nome e o segundo para o salário dos funcionários.


            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "José Aparecido Silva";
            funcionario1.salario = 2500;

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nome = "Vilma Sousa";
            funcionario2.salario = 2700;

            Console.WriteLine("Dados do funcionário 1");
            Console.WriteLine($"Nome: {funcionario1.nome}");
            Console.WriteLine($"Salário: {funcionario1.salario}");

            Console.WriteLine("----------------------");

            Console.WriteLine("Dados do funcionário 2");
            Console.WriteLine($"Nome: {funcionario2.nome}");
            Console.WriteLine($"Salário: {funcionario2.salario}");
        }   
    }

    class Funcionario
    {
        public string? nome;
        public decimal salario;
    }
}
