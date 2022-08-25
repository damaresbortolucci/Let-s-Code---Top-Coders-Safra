
namespace Aula1_POO_Atributos
{
    public class MetodosGerente
    {
        public static void Main(string[] args)
        {
            Gerente2 ge = new Gerente2("Joaquim Oliveira", 5500);

            Console.WriteLine("Consulta de salário");
            Console.WriteLine(ge.imprimeSalario().ToString("C"));

            Console.WriteLine();

            Console.WriteLine("Consulta dados do Gerente\n");
            ge.ConsultaDados();

        
        }
    }

    public class Gerente2
    {
        private string? nome;
        private double salario;

        public string? Nome { get; set; }
        public double Salario { get; set;}
        

        public Gerente2(string? nome)
        {
            Nome = nome;
        }

        public Gerente2(string? nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public double imprimeSalario()
        {
            return Salario;

        }

        public void ConsultaDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: {Salario:C}");
        }       
    }
}
