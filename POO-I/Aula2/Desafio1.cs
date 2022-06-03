namespace Aula2
{
    class Desafio1
    {
        static void Main(string[] args)
        {
            //1 - Crie uma classe chamada Aluno para definir os objetos que representarão os alunos de uma escola.
            //Nessa classe, declare três atributos: o primeiro para o nome, o segundo para o RG e o terceiro para a data de nascimento dos alunos.

            Aluno aluno1 = new Aluno();
            aluno1.nome = "Dâmares Sousa";
            aluno1.rg = "42.603.766-2";
            aluno1.dataNascimento = "11/04/1987";

            Aluno aluno2 = new Aluno();
            aluno2.nome = "Renato Mendes";
            aluno2.rg = "50.444.456-2";
            aluno2.dataNascimento = "10/10/1982";

            Console.WriteLine("Dados do aluno 1");
            Console.WriteLine($"Nome: {aluno1.nome}");
            Console.WriteLine($"N° do RG: {aluno1.rg}");
            Console.WriteLine($"Data de nascimento: {aluno1.dataNascimento}");

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Dados do aluno 2");
            Console.WriteLine($"Nome: {aluno2.nome}");
            Console.WriteLine($"N° do RG: {aluno2.rg}");
            Console.WriteLine($"Data de nascimento: {aluno2.dataNascimento}");
        }
    }

    class Aluno
    {
        public string? nome;
        public string? rg;
        public string? dataNascimento;
    }
}