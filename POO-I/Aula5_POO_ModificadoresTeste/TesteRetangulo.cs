using Aula5_POO_Modificadores;

namespace Aula5_POO_ModificadoresTeste
{
    public class TesteRetangulo
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Retângulo 1");

                Retangulo ret1 = new Retangulo(15, 10);
                Console.WriteLine($"Largura: {ret1.Largura}");
                Console.WriteLine($"Comprimento: {ret1.Comprimento}");
                Console.WriteLine($"Área: {ret1.Area()}cm²");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            try
            {
                Console.WriteLine("Retângulo 2");

                Retangulo ret2 = new Retangulo(0, 10);
                Console.WriteLine($"Largura: {ret2.Largura}");
                Console.WriteLine($"Comprimento: {ret2.Comprimento}");
                Console.WriteLine($"Área: {ret2.Area()}cm²");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
