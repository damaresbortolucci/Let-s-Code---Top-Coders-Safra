using Aula5_POO_Modificadores;

namespace Aula5_POO_ModificadoresTeste
{
    public class TesteConta
    {
        public static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.Saldo = 1000;
            Console.WriteLine(conta.Saldo);
        }
    }
}