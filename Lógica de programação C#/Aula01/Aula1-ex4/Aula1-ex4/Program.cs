public class Program
{
    public static void Main()
    {
        string numero;
        string numeroFormatado;
        bool StringTemConteudo;

        do
        {
            Console.Write("Informe o CPF/CNPJ (somente números): ");
            numero = Console.ReadLine();
            numero.Trim();
            StringTemConteudo = !String.IsNullOrWhiteSpace(numero);

            if (!StringTemConteudo || numero.Length > 14)
            {
                Console.Clear();
                Console.WriteLine("Digite um valor válido");
            }

            if(numero.Length <= 11)
            {
                numeroFormatado = numero.PadLeft(11, '0');
                numeroFormatado = numeroFormatado.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                Console.WriteLine(numeroFormatado);
            }
            else if(numero.Length <= 14)
            {
                numeroFormatado = numero.PadLeft(14, '0');
                numeroFormatado = numeroFormatado.Insert(2, ".").Insert(6, ".").Insert(10, "/").Insert(15, "-");
                Console.WriteLine(numeroFormatado);
            }

        } while (!StringTemConteudo || numero.Length > 14);

    }
}