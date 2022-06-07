using System;

namespace Aula1_POO_Atributos
{
    class TesteAgencia
    {
        public static void Main(string[] args)
        {
            Agencia ag1 = new Agencia();
            ag1.numero = 3524;

            Agencia ag2 = new Agencia();
            ag2.numero = 1515;

            Console.WriteLine("Dados da primeira agência");
            Console.WriteLine($"Número: {ag1.numero}");

            Console.WriteLine("---------------------------");

            Console.WriteLine("Dados da segunda agência");
            Console.WriteLine($"Número: {ag2.numero}");
        }
    }

    class Agencia
    {
        //As agências do banco possuem número.
        //Crie uma classe chamada Agencia para definir os objetos que representarão as agências do banco.

        public int numero;

    }
}
