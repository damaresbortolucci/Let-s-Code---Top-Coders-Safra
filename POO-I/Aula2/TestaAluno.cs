using System.Globalization;


namespace Aula2_POO_Desafios
{
    class TestaAluno
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Dâmares Sousa", "42.603.766-2", "11/04/1987");
            Aluno aluno2 = new Aluno("Renato Mendes", "50.444.456-2", "10/10/1982");

            Console.WriteLine("Dados do aluno 1");
            Console.WriteLine($"Nome: {aluno1.nome}");
            Console.WriteLine($"N° do RG: {aluno1.rg}");
            Console.WriteLine($"Data de nascimento: {aluno1.dataNascimento}");
            aluno1.rematrícula(new DateTime(2022, 5, 20));
            Console.WriteLine($"Valor da mensalidade com desconto: {aluno1.pgMensalidadeDesconto(500m)}");

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Dados do aluno 2");
            Console.WriteLine($"Nome: {aluno2.nome}");
            Console.WriteLine($"N° do RG: {aluno2.rg}");
            Console.WriteLine($"Data de nascimento: {aluno2.dataNascimento}");
            aluno2.rematrícula();
            Console.WriteLine($"Valor da mensalidade com desconto: {aluno2.pgMensalidadeDesconto(500m, 0.15m)}");
        }
    }

    
}