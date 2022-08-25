
namespace Aula8_POO_Poliformismo2
{
    class Telefonista : Funcionario
    {
        private int codigoEstacao;

        public Telefonista(string nome, decimal salario, int codigoEstacao) : base(nome, salario)
        {
            CodigoEstacao = codigoEstacao;
        }

        public int CodigoEstacao
        {
            get { return codigoEstacao; }
            set
            {
                codigoEstacao = value;
            }
        }

        public override decimal Bonificacao()
        {
            return base.Bonificacao();
        }

        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Código da estação: {CodigoEstacao}");
        }
    }
}
