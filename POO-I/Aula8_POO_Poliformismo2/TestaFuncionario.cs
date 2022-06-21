
namespace Aula8_POO_Poliformismo2
{
    class TestaFuncionario
    {
        public static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Mário Andrade", 6500, "gerente054", "J23F5");
            Secretaria secretaria = new Secretaria("Ana Maria Oliveira", 3500, 201);
            Telefonista telefonista = new Telefonista("Sandra Gomes", 2300, 102);

            Console.WriteLine("** Dados do gerente **");
            gerente.MostraDados();

            Console.WriteLine();

            Console.WriteLine("** Dados da secretária **");
            secretaria.MostraDados();

            Console.WriteLine();

            Console.WriteLine("** Dados da telefonista **");
            telefonista.MostraDados();
        }
    }
}
