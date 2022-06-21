using System.Globalization;

namespace Aula3_POO_Desafios
{
    class Desafio2_MetodosFuncionario
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1 = new Funcionario();
            funcionario1.nome = "José Aparecido Silva";
            funcionario1.salario = 2500;

            Funcionario funcionario2 = new Funcionario();
            funcionario2.nome = "Vilma de Sousa";
            funcionario2.salario = 2700;

            funcionario1.AumentaSalario(500.00M);
            funcionario2.AumentaSalario(200.00M);

            Console.WriteLine("Dados do funcionário 1");
            funcionario1.ConsultaDados();
           
            Console.WriteLine("----------------------");

            Console.WriteLine("Dados do funcionário 2");
            funcionario2.ConsultaDados();

        }
    }

    class Funcionario
    {
        public string? nome;
        public decimal salario;

        public void AumentaSalario(decimal aumento)
        {
            salario += aumento;
        }

        public void ConsultaDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário: {salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
    }
}
