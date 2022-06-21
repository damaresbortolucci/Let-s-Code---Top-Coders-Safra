namespace Aula7_POO_Desafio4_1
{
    class Pedido
    {
        private int id;
        private decimal valorPedido;
        
        public decimal ValorPedido
        {
            get { return valorPedido; }
            set {valorPedido = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Pedido(int id, decimal valorPedido)
        {
            ValorPedido = valorPedido;
            Id = id;
        }
    }
}