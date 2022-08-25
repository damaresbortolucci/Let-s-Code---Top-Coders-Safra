
namespace Aula7_POO_Heranca
{
    class SeguroVeicular : Servico
    {
        public Veiculo veiculo;
        public double valorSeguroVeiculo;
        public double franquia;

        public override double CalculaTaxa()
        {
            return base.CalculaTaxa() + this.veiculo.valor * 0.5;
        }
    }
}
