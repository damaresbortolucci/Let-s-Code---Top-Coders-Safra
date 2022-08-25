using System.Globalization;

namespace Aula1_POO_Atributos
{
    class TesteConta
    {
        public static void Main(string[] args)
        {
            Agencia ag = new Agencia(3793);

            Conta c1 = new Conta(ag);
            c1.numero = 1234;
            c1.saldo = 1000;
            //c1.limite está vindo com valor padrão do construtor

            Conta c2 = new Conta(ag);
            c2.numero = 5678;
            c2.saldo = 2000;
            //c2.limite está vindo com valor padrão do construtor


            //Teste dos métodos
            c1.Deposito(400);
            c1.Saca(1500);

            c2.Deposito(250);
            c2.Saca(100);

            
            Console.WriteLine("Dados da primeira conta ");
            Console.WriteLine("Número da Conta: " + c1.numero);
            Console.WriteLine("Saldo da Conta: " + c1.saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Testa valor padrão para limite que é 1500,00
            Console.WriteLine("Limite do Cheque Especial: " + c1.limite.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine("-------------------------");

            Console.WriteLine("Dados da segunda conta ");
            Console.WriteLine("Número da Conta: " + c2.numero);
            Console.WriteLine("Saldo da Conta: " + c2.saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Testa valor padrão para limite que é 1500,00
            Console.WriteLine("Limite do Cheque Especial: " + c2.limite.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }


    class Conta
    {
        public int numero;
        public decimal saldo;
        public decimal limite=1500;
        public Agencia agencia;


        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }


        public void Deposito(decimal valorDeposito)
        {
            saldo += valorDeposito;
        }


        public void Saca(decimal valorSaque)
        {
            bool autorizadoSaque = VerificaSaldo(valorSaque);

            if (autorizadoSaque)
            {
                if (saldo >= valorSaque)
                    this.saldo -= valorSaque;
                else
                {
                    this.limite = this.limite - (valorSaque - this.saldo);
                    this.saldo = this.saldo - valorSaque;
                }
            }
            else
                Console.WriteLine("Saldo insuficiênte para saque");
        }


        public bool VerificaSaldo(decimal valorSaque)
        {
            bool podeSacar = true;
            if ((saldo + limite) < valorSaque)
            {
                podeSacar = false;
            }
            return podeSacar;
        }

     

        public void ImprimirExtrato(int dias = 15)
        {
            //implementar BD
        }

        public void ImprimirExtrato()
        {
            this.ImprimirExtrato(15);
        }

        public decimal consultaSaldo()
        {
            return this.saldo;
        }
    }
}
