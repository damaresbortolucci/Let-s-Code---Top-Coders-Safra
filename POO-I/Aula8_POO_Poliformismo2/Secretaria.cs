
namespace Aula8_POO_Poliformismo2
{
    class Secretaria : Funcionario
    {
        private int ramal;

        public Secretaria(string nome, decimal salario, int ramal) : base(nome, salario)
        {
            Ramal = ramal;
        }

        public int Ramal
        {
            get { return ramal; }
            set
            {
                ramal = value;
            }
        }

        public override decimal Bonificacao()
        {
            return base.Bonificacao();
        }


        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Ramal: {Ramal}");
        }
    }
}
