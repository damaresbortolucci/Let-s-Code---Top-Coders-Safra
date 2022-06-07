using System;


namespace Aula1_POO_Atributos
{
    class TesteCartaoCredito
    {
        public static void Main(string[] args)
        {
            CartaoCredito cc1 = new CartaoCredito();
            cc1.numero = 5102454515457898;
            cc1.nome = "José da Silva";
            cc1.dataValidade = "01/01/2026";
            cc1.codSeguranca = 706;

            CartaoCredito cc2 = new CartaoCredito();
            cc2.numero = 4180454332457878;
            cc2.nome = "Dâmares Sousa";
            cc2.dataValidade = "01/06/2028";
            cc2.codSeguranca = 502;

            Console.WriteLine($"Dados do primeiro cartão");
            Console.WriteLine($"Número: {cc1.numero}");
            Console.WriteLine($"Nome: {cc1.nome}");
            Console.WriteLine($"Data de validade: {cc1.dataValidade}");
            Console.WriteLine($"Código de segurança: {cc1.codSeguranca}");

            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"Dados do segundo cartão");
            Console.WriteLine($"Número: {cc2.numero}");
            Console.WriteLine($"Nome: {cc2.nome}");
            Console.WriteLine($"Data de validade: {cc2.dataValidade}");
            Console.WriteLine($"Código de segurança: {cc2.codSeguranca}");
        }
    }


    class CartaoCredito
    {
        //Os bancos oferecem aos clientes a possibilidade de obter um cartão de crédito que pode ser utilizados para fazer compras.
        //Um cartão de crédito possui um número e uma data de validade.
        //Crie uma classe chamada CartaoDeCredito para modelar os objetos que representarão os cartões de crédito.

        public long numero;
        public string? nome;
        public string? dataValidade;
        public int codSeguranca;
    }
}
