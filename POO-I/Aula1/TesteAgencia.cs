using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
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
}
