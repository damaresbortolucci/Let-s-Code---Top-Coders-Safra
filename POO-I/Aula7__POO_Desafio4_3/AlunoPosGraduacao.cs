
namespace Aula7__POO_Desafio4_3
{
    class AlunoPosGraduacao : AlunoGraducao
    {
        private byte linhaDePesquisa;
        private string? orientador;
        private double bolsaDeEstudos;

        public byte LinhaDePesquisa { get => linhaDePesquisa; set => linhaDePesquisa = value; }
        public string? Orientador { get => orientador; set => orientador = value; }
        public double BolsaDeEstudos { get => bolsaDeEstudos; set => bolsaDeEstudos = value; }


        public AlunoPosGraduacao(int matricula, string? nome, DateTime nascimento, ECurso curso, double percentualCobranca, byte linhaDePesquisa, string? orientador, double bolsaDeEstudos) : base(matricula, nome, nascimento, curso, percentualCobranca)
        {
            LinhaDePesquisa = linhaDePesquisa;
            BolsaDeEstudos = bolsaDeEstudos;
            Orientador = orientador;
        }

        public override double CalculaMensalidade()
        {
            double valor = base.CalculaMensalidade();
            return valor - this.BolsaDeEstudos;
        }

        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Linha de pesquisa: {LinhaDePesquisa}");
            Console.WriteLine($"Orientador: {Orientador}");
            Console.WriteLine($"Bolsa de estudos: {BolsaDeEstudos:c}");
        }
    }
}
