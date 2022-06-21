
namespace Aula1_POO_Atributos
{
    class TesteAgencia
    {
        public static void Main(string[] args)
        {
            Agencia ag1 = new Agencia(3524);
            Agencia ag2 = new Agencia(1515);

            Console.WriteLine("Primeira agência");
            Console.WriteLine($"Número: {ag1.numero}");

            Console.WriteLine("------------------------");

            Console.WriteLine("Segunda agência");
            Console.WriteLine($"Número: {ag2.numero}");
        }
    }

    class Agencia
    {
        public int numero;

        public Agencia(int numero)
        {
            this.numero = numero;
        }
    }
}
