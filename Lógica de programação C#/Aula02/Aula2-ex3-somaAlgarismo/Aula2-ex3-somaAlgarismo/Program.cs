public class Program
{
    public static void Main()
    {

        Console.Write("Digite um número: ");
        string numero = Console.ReadLine();

        int stringToInt = int.Parse(numero.ToString());
        int soma = 0;

        if (stringToInt > 0)
        {
            foreach (char c in numero)
            {
                int charToInt = int.Parse(c.ToString());
                soma += charToInt;
            }
            Console.WriteLine($"A soma de todos os seus algarismos é {soma}");
        }
        else
            Console.WriteLine("Número inválido");

    }
}
