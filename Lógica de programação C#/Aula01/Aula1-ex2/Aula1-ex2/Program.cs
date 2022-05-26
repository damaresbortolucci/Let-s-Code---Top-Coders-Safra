public class Program
{
    static List<char> palavraDigitada = new List<char>();
    static List<char> palavraInvertida = new List<char>();
    static string? palavra;

    public static void Main()
    {

        int contador = 0;

        do
        {
            Console.Write("Digite uma palavra/frase: ");
            palavra = Console.ReadLine();
        } while (palavra.Length < 2);


        Console.WriteLine(palavra);

        guardaPalavra();
        invertePalavra();

        foreach (char c in palavraInvertida)
        {
            Console.Write(c);
        }

        palavra = palavra.Replace(" ", String.Empty).Replace("-", String.Empty).Replace(",", String.Empty).Replace(".", String.Empty);
        palavraDigitada.Clear();
        palavraInvertida.Clear();

        guardaPalavra();
        invertePalavra();


        for (int i = 0; i < palavraDigitada.Count; i++)
        {
            if (palavraDigitada[i] == palavraInvertida[i])
                contador++;
        }


        if (contador == palavraDigitada.Count)
            Console.WriteLine("\nÉ um palíndromo!");
        else
            Console.WriteLine("\nNão é um palíndromo!");

    }

    static void guardaPalavra()
    {
        foreach (char c in palavra)
        {
            palavraDigitada.Add(c);
        }
    }


    static void invertePalavra()
    {
        for (int i = palavraDigitada.Count - 1; i >= 0; i--)
        {
            palavraInvertida.Add(palavraDigitada[i]);

        }
    }
}
