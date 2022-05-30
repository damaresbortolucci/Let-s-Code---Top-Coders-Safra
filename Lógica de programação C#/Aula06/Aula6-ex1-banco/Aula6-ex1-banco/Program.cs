public class Program

{
    public static void Main()
    {
        /*Faça um programa que apresente quatro opções: 
                (a)consulta saldo, (b)saque, (c)depósito e (d)sair. 
                O saldo deve iniciar em R$ 0,00. A cada saque ou depósito o valor do saldo deve 
                ser atualizado e apresentado na tela.*/

        decimal saldo = 0.00M;
        bool retorno;
        int opcao;

        do
        {
            Console.WriteLine("\n*****   Menu   *****\n");
            Console.WriteLine("1 - Consulta saldo");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Depósito");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            retorno = int.TryParse(Console.ReadLine(), out opcao);

            if (opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"\nConsulta de saldo");
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\nValor do saque R$: ");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());
                        saldo = saldo - valorSaque;

                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\nValor do depósito R$: ");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());
                        saldo = saldo + valorDeposito;
                        break;
                }
                Console.Write($"Saldo atual: {saldo:C}\n");
            }

        } while (!retorno || opcao != 4);

    }
}
