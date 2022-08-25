using System;

namespace Aula2._1_POO_Exercicios
{
    class Ex3_RegistroAcademico
    {
        public static void Main(string[] args)
        {
            RegistroAcademico aluno1 = new RegistroAcademico();
            aluno1.nome = "Ana da Silva";
            aluno1.matricula = 1234;
            aluno1.dataNascimento = "11/04/1987";
            aluno1.bolsista = true;
            aluno1.anoMatricula = 2022;
            aluno1.CalculaMensalidade(aluno1.bolsista);
            aluno1.MostrarDados();

            Console.WriteLine();

            RegistroAcademico aluno2 = new RegistroAcademico();
            aluno2.nome = "José da Silva";
            aluno2.matricula = 5544;
            aluno2.dataNascimento = "25/06/1990";
            aluno2.bolsista = false;
            aluno2.anoMatricula = 2021;
            aluno2.CalculaMensalidade(aluno2.bolsista);
            aluno2.MostrarDados();
        }
    }

    class RegistroAcademico{

        public string? nome;
        public int matricula;
        public string? dataNascimento;
        public bool bolsista;
        public int anoMatricula;
        public decimal mensalidade = 650.00M;


        public decimal CalculaMensalidade(bool temBolsa)
        {
            if (temBolsa)
                return mensalidade = mensalidade / 2;
            else
                return mensalidade;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Dados do aluno");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Data de nascimento: {dataNascimento}");
            Console.WriteLine($"Tem bolsa: {bolsista}");
            Console.WriteLine($"Ano de matrícula: {anoMatricula}");
            Console.WriteLine($"Valor da mensalidade: R$ {mensalidade}");
        }
    }        
}
