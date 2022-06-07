namespace Aula3_POO_Desafios
{
    class Desafio1_AlunoTurma
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma();
            turma.periodo = 1;
            turma.serie = 8;
            turma.sigla = "A";
            turma.tipoEnsino = "Fundamental";

            Aluno aluno = new Aluno();
            aluno.nome = "Dâmares Sousa";
            aluno.rg = "42.603.766-2";
            aluno.dataNascimento = "11/04/1987";
            aluno.turma = turma;

            //alterações
            aluno.turma.periodo = 2;
            aluno.turma.serie = 9;
            aluno.turma.sigla = "B";

            Console.WriteLine("*** Dados do aluno ***\n");
            Console.WriteLine($"Nome: {aluno.nome}");
            Console.WriteLine($"RG: {aluno.rg}");
            Console.WriteLine($"Nascimento: {aluno.dataNascimento}");
            Console.WriteLine("\n--- Dados da Turma ---");
            Console.WriteLine($"Período: {aluno.turma.periodo}");
            Console.WriteLine($"Série: {aluno.turma.serie}");
            Console.WriteLine($"Sigla: {aluno.turma.sigla}");
            Console.WriteLine($"Tipo de ensino: {aluno.turma.tipoEnsino}");

        }
    }

    class Aluno
    {
        public string? nome;
        public string? rg;
        public string? dataNascimento;
        public Turma turma;
    }

    class Turma
    {
        public int periodo;
        public int serie;
        public string? sigla;
        public string? tipoEnsino;
    }
}