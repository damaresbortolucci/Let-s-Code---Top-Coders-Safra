
namespace Aula7_POO_Desafio4_1
{
    class Boleto : Pagamento
    {
        private string? codigoBarras;
        private string? banco;
        private int agencia;

        public string? CodigoBarras { get => codigoBarras; set => codigoBarras = value; }   
        public string? Banco { get => banco; set => banco = value; }    
        public int Agencia { get => agencia; set => agencia = value; }  

        public Boleto(Pedido pedido, DateTime dataPagamento, string? codigoBarras, string? banco, int agencia) : base(pedido, dataPagamento)
        {
            CodigoBarras = codigoBarras;
            Banco = banco;
            Agencia = agencia;
        }

        public override decimal CalculaPagamento()
        {
            return base.CalculaPagamento();
        }
    }
}
