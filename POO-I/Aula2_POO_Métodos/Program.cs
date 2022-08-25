namespace Aula2_POO_Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        class pessoa
        {
            public string? nome;
            public DateTime dataNascimento;
            public float peso;
            public float altura;

            public void imprimirDados()
            {
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Data de nascimento: {dataNascimento}");
                Console.WriteLine($"Peso: {peso}");
                Console.WriteLine($"Altura: {altura}");
            }

            public int calculaIdade()
            {
                return DateTime.Today.Year - dataNascimento.Year;
            }
        }
    }
}