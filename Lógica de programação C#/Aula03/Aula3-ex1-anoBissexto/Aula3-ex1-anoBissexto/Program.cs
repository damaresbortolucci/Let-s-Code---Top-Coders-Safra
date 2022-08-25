public class Program

{
    public static void Main()
    {

        //Determine se um determinado ano lido é bissexto. Aplique as regras abaixo conforme exemplificado
        //pela Microsoft:

        //Se o ano for uniformemente divisível por 4, vá para a etapa 2.Caso contrário, vá para a etapa 5.
        //Se o ano for uniformemente divisível por 100, vá para a etapa 3.Caso contrário, vá para a etapa 4.
        //Se o ano for uniformemente divisível por 400, vá para a etapa 4.Caso contrário, vá para a etapa 5.
        //O ano é bissexto(tem 366 dias).
        //O ano não é um ano bissexto(tem 365 dias).


        Console.WriteLine("Informe o ano: ");
        int ano = int.Parse(Console.ReadLine());

        //método microsoft
        if (ano % 4 == 0)
        {
            if (ano % 100 == 0)
            {
                if (ano % 400 == 0)
                    Console.WriteLine("O ano é bissexto (tem 366 dias).");
                else
                    Console.WriteLine("O ano não é um ano bissexto (tem 365 dias)");
            }
            else
                Console.WriteLine("O ano é bissexto (tem 366 dias).");
        }
        else
            Console.WriteLine("O ano não é um ano bissexto (tem 365 dias)");



        ////método opcional
        ///
        //if ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0))
        //    Console.WriteLine("O ano é bissexto (tem 366 dias).");
        //else
        //    Console.WriteLine("O ano não é um ano bissexto (tem 365 dias)");

    }
}