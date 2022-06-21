namespace Aula4_POO
{
    class Ex1_Conta
    {
        static void Main(string[] args)
        {

            Conta c1 = new Conta(10828, 100M, 1000m);
            c1.deposito(100m);
            c1.saque(50m);
            c1.saque(150m);
            c1.deposito(300m);
            c1.deposito(50m);

            Console.WriteLine("Conta corrente n° 10828");
            c1.extrato();

            Console.WriteLine();

            Conta c2 = new Conta(25065, 1500M, 2000m);
            c2.deposito(500m);
            c2.saque(650m);
            c2.deposito(450m);
            c2.deposito(50m);

            Console.WriteLine("Conta corrente n° 25065");
            c2.extrato();


        }
    }

    class Transacao
    {
        public DateTime data;
        public int idTransacao = 0;
        public string tipoTransacao;
        public decimal valor;

        public Transacao(string tipoTransacao, decimal valor)
        {
            this.idTransacao += 1;
            this.data = DateTime.Today;
            this.tipoTransacao = tipoTransacao;
            this.valor = valor;
        }
    }

    class Conta
    {
        public int numero;
        public decimal saldo;
        public decimal limite;
        List<Transacao> transacoes = new List<Transacao>();
        

        public Conta(int numero, decimal saldo, decimal limite)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = limite;
        }


        public void deposito(decimal valor)
        {
            Transacao deposito = new Transacao("depósito", valor);
            transacoes.Add(deposito);
            this.saldo += valor;
        }

        public void saque(decimal valor)
        {
            Transacao saque = new Transacao("saque", valor);
            transacoes.Add(saque);
            this.saldo -= valor;
        }

        public void extrato()
        {
            Console.WriteLine("--------------- Extrato ----------------");
            Console.WriteLine("Data".PadRight(15) + "Transação".PadRight(15) + "Valor".PadRight(15));

            foreach (Transacao transacao in transacoes)
            {   
                Console.Write($"{transacao.data.ToString("d").PadRight(15)}");
                Console.Write($"{transacao.tipoTransacao.PadRight(15)}");
                Console.WriteLine($"{transacao.valor:C}");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Saldo atual: {consultaSaldo():C}");
        }

        public decimal consultaSaldo()
        {
            return this.saldo;
        }
    }
}
