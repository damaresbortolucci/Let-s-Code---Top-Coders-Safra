
namespace Aula7_POO_Desafio4_1
{
    class CartaoCredito : Pagamento
    {
        public CartaoCredito(Pedido pedido, DateTime dataPagamento) : base(pedido, dataPagamento)
        {
        }

        public override decimal CalculaPagamento()
        {
            return ValorPagamento = pedido.ValorPedido + (pedido.ValorPedido * 0.04m);
        }
    }
}
