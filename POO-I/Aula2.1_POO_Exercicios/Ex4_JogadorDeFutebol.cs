using System;
using System.Collections.Generic;


namespace Aula2._1_POO_Exercicios
{
    internal class Ex4_JogadorDeFutebol
    {
        public static void Main(string[] args)
        {

            JogadorDeFutebol jogador1= new JogadorDeFutebol();
            jogador1.nome = "Neymar Júnior";
            jogador1.posicao = "atacante";
            jogador1.dataNascimento = new DateTime(1992, 2, 5);
            jogador1.nacionalidade = "brasileiro";
            jogador1.altura = 1.75f;
            jogador1.peso = 68.0f;

            jogador1.MostrarDados();

            int idade1 = jogador1.CalculaIdade(jogador1.dataNascimento);
            Console.WriteLine($"Idade: {idade1}");

            jogador1.TempoParaAposentadoria(idade1);

            Console.WriteLine();

            JogadorDeFutebol jogador2 = new JogadorDeFutebol();
            jogador2.nome = "Daniel Alves";
            jogador2.posicao = "defesa";
            jogador2.dataNascimento = new DateTime(1984, 5, 6);
            jogador2.nacionalidade = "brasileiro";
            jogador2.altura = 1.72f;
            jogador2.peso = 71.0f;

            jogador2.MostrarDados();

            int idade2 = jogador2.CalculaIdade(jogador2.dataNascimento);
            Console.WriteLine($"Idade: {idade2}");

            jogador2.TempoParaAposentadoria(idade2);
                   
        }
    }


    class JogadorDeFutebol
    {

        public string? nome;
        public string? posicao;
        public DateTime dataNascimento;
        public string? nacionalidade;
        public float altura;
        public float peso;

        public void MostrarDados()
        {
            Console.WriteLine("*** Dados do jogador ***");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Posição: {posicao}");
            Console.WriteLine($"Data de nascimento: {dataNascimento:d}");
            Console.WriteLine($"Nacionalidade: {nacionalidade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Peso: {peso}kg");
        }


        public int CalculaIdade(DateTime nascimento)
        {
            return DateTime.Today.Year - nascimento.Year;
        }


        public void TempoParaAposentadoria(int idade)
        {
           int tempoFaltante=0;

           if (posicao == "defesa")
                tempoFaltante = 40 - idade;

           else if(posicao == "meio-campo")
                tempoFaltante = 38 - idade;

           else if(posicao == "atacante")
                tempoFaltante = 35 - idade;

           Console.WriteLine($"Anos faltantes para aposentadoria: {tempoFaltante}");
        }

    }
}
