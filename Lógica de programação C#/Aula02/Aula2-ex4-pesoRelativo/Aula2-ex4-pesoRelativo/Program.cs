public class Program
{
    public static void Main()
    {

        /*Escreva um programa que leia um peso na Terra e o número de um planeta e imprima o valor 
         * do seu peso neste planeta.A relação de planetas é dada a seguir juntamente com o valor das 
         * gravidades relativas à Terra*/

        string planeta = "";
        decimal gravidadeRelativa = 0.0M;

            Console.WriteLine("*** Conversor de Peso ***");
            Console.Write("\nInforme o peso (kg): ");
            decimal peso = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n*** Selecione o planeta ***\n");
            Console.WriteLine("1 - Mercúrio");
            Console.WriteLine("2 - Vênus");
            Console.WriteLine("3 - Marte");
            Console.WriteLine("4 - Júpiter");
            Console.WriteLine("5 - Saturno");
            Console.WriteLine("6 - Urano");
            Console.Write("\nOpção: ");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    planeta = "Mercúrio";
                    gravidadeRelativa = 0.37M;
                    break;
                case 2:
                    planeta = "Vênus";
                    gravidadeRelativa = 0.88M;
                    break;
                case 3:
                    planeta = "Marte";
                    gravidadeRelativa = 0.38M;
                    break;
                case 4:
                    planeta = "Júpiter";
                    gravidadeRelativa = 2.64M;
                    break;
                case 5:
                    planeta = "Saturno";
                    gravidadeRelativa = 1.15M;
                    break;
                case 6:
                    planeta = "Urano";
                    gravidadeRelativa = 1.17M;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine($"\nO peso em {planeta} é {peso * gravidadeRelativa} kg");

     }
}
