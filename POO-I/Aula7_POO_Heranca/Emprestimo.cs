
namespace Aula7_POO_Heranca
{
    class Emprestimo : Servico
    {
        public double valor;
        public double taxa;


        public override double CalculaTaxa()
        {
            return this.valor * 0.1 + 5;
        }
    }
}
