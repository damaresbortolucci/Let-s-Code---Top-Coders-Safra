
namespace Aula2_POO_Desafios
{
    class TestaTurma
    {
        public static void Main(string[] args)
        {
            //3 - Em uma escola, os alunos precisam ser divididos por turmas, que devem ser representadas dentro da aplicação.
            //Crie uma classe chamada Turma que contenha quatro atributos: o primeiro para o período, o segundo para definir a série, o terceiro para sigla e o quarto para o tipo de ensino.


            Turma turma1 = new Turma();
            turma1.periodo = 1;
            turma1.serie = 8;
            turma1.sigla = "A";
            turma1.tipoEnsino = "Fundamental";

            Turma turma2 = new Turma();
            turma2.periodo = 2;
            turma2.serie = 8;
            turma2.sigla = "B";
            turma2.tipoEnsino = "Fundamental";

            Console.WriteLine("Primeira Turma");
            Console.WriteLine($"Período: {turma1.periodo}");
            Console.WriteLine($"Série: {turma1.serie}");
            Console.WriteLine($"Sigla: {turma1.sigla}");
            Console.WriteLine($"Tipo de ensino: {turma1.tipoEnsino}");

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Segunda Turma");
            Console.WriteLine($"Período: {turma2.periodo}");
            Console.WriteLine($"Série: {turma2.serie}");
            Console.WriteLine($"Sigla: {turma2.sigla}");
            Console.WriteLine($"Tipo de ensino: {turma2.tipoEnsino}");
        }
    }

    class Turma
    {
        public int periodo;
        public int serie;
        public string? sigla;
        public string? tipoEnsino;
    }
}
