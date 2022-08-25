
namespace Aula7_POO_Desafio4_1
{
    class TestaPedido
    {
        public static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido(01, 1200m);

            Console.WriteLine("Opções de pagamento");

            Boleto boleto = new Boleto(pedido1, DateTime.Today, "0001 0005 0005", "Safra", 0071);
            Console.WriteLine($"Boleto:  {boleto.CalculaPagamento():c}");

            CartaoDebito pagCD = new CartaoDebito(pedido1, DateTime.Today);
            Console.WriteLine($"Cartão de débito: {pagCD.CalculaPagamento():c}");

            CartaoCredito pagCC = new CartaoCredito(pedido1, DateTime.Today);
            Console.WriteLine($"Cartao de crédito: {pagCC.CalculaPagamento():c}");
        }
    }
}
