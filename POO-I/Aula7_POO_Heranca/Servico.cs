
namespace Aula7_POO_Heranca
{
    class Servico
    {
        public Cliente contratante;
        public Funcionario responsavel;
        public string dataContratacao;

        public virtual double CalculaTaxa()
        {
            return 5;
        }
    }
}