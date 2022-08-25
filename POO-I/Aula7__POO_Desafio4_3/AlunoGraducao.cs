
namespace Aula7__POO_Desafio4_3
{
    class AlunoGraducao
    {
        private int matricula;
        private string? nome;
        private DateTime nascimento;
        private double percentualCobranca;
        private ECurso curso;
        private string? nomeCurso;

        public string? Nome { get => nome; set => nome = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public double PercentualCobranca { get => percentualCobranca; set => percentualCobranca = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public ECurso Curso { get => curso; set => curso = value; }
        public string? NomeCurso { get => nomeCurso; set => nomeCurso = value; }

        public AlunoGraducao(int matricula, string? nome, DateTime nascimento, ECurso curso, double percentualCobranca)
        {
            Matricula = matricula;
            Nome = nome;
            Nascimento = nascimento;
            Curso = curso;
            PercentualCobranca = percentualCobranca;
        }

        public virtual double CalculaMensalidade()
        {
            double valor = 0.0;

            switch (this.Curso)
            {
                case ECurso.ARQUITETURA:
                    valor = 450;
                   
                    break;
                case ECurso.CIENCIADACOMPUTACAO:
                    valor = 650;
                    nomeCurso = "Ciência da Computação";
                    break;
                case ECurso.ENGENHARIA:
                    valor = 850;
                    nomeCurso = "Engenharia";
                    break;
                case ECurso.BIOMEDICINA:
                    valor = 750;
                    nomeCurso = "Biomedicina";
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return valor * (PercentualCobranca/100);
        }

        public virtual void MostraDados()
        {
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nascimento: {Nascimento.ToString("d")}");

            if (Curso == ECurso.CIENCIADACOMPUTACAO)
                nomeCurso = "Ciência da Computação";
            else if(Curso == ECurso.BIOMEDICINA)
                nomeCurso = "Biomedicina";
            else if (Curso == ECurso.ARQUITETURA)
                nomeCurso = "Arquitetura";
            else if (Curso == ECurso.ENGENHARIA)
                nomeCurso = "Engenharia";

            Console.WriteLine($"Curso: {nomeCurso}");
            Console.WriteLine($"Percentual de cobrança: {PercentualCobranca}%");
        }
    }

    enum ECurso
    {
        ARQUITETURA = 1,
        CIENCIADACOMPUTACAO = 2,
        ENGENHARIA = 3,
        BIOMEDICINA = 4
    }
}
