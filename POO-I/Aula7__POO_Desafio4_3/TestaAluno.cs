namespace Aula7__POO_Desafio4_3
{
    class TestaAluno
    {
        static void Main(string[] args)
        {
            AlunoGraducao alunoGraduacao = new AlunoGraducao(101,"Ana Antunes", new DateTime(1987, 04, 11), ECurso.CIENCIADACOMPUTACAO,100);

            AlunoPosGraduacao alunoPosGraduacao = new AlunoPosGraduacao(102,"José da Silva", new DateTime(1990, 11, 05), ECurso.CIENCIADACOMPUTACAO, 100, 2, "João Marcos", 200);


            Console.WriteLine($"Aluno da Graduação");
            Console.WriteLine("-----------------------");
            alunoGraduacao.MostraDados();
            Console.WriteLine($"Mensalidade: {alunoGraduacao.CalculaMensalidade():C}");

            Console.WriteLine();

            Console.WriteLine($"Aluno da Pós-graduação");
            Console.WriteLine("-----------------------");
            alunoPosGraduacao.MostraDados();
            Console.WriteLine($"Mensalidade: {alunoPosGraduacao.CalculaMensalidade():C}");
           
        }
    }
}