
namespace Aula7_POO_Desafio4_1
{
    class Pagamento
    {
        private decimal valorPagamento;
        private DateTime dataPagamento;
        public Pedido pedido;

        public decimal ValorPagamento { get { return valorPagamento; } set { valorPagamento = value; } }
        public DateTime DataPagamento { get { return dataPagamento; } set { dataPagamento = value; } }

        public Pagamento(Pedido pedido, DateTime dataPagamento)
        {
            this.pedido = pedido;
            DataPagamento = dataPagamento;
        }

        public virtual decimal CalculaPagamento()
        {
            return ValorPagamento = this.pedido.ValorPedido;
        }
    }
}
