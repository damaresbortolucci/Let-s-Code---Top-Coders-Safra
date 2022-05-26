public class Program
{
    public static void Main()
    {

        string documento;
        bool StringTemConteudo;

        do
        {
            Console.Write("Informe o número do CPF/CNPJ com pontuação: ");
            documento = Console.ReadLine();  
            StringTemConteudo = !String.IsNullOrWhiteSpace(documento);

            if (!StringTemConteudo || (documento.Length<14 || documento.Length>18))
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite um valor válido"); 
            }
            else
            {
                documento.Trim();
                string documentoFormatado = documento.Replace(".", "").Replace("-", "").Replace("/", "");
                Console.WriteLine($"Valor informado: {documentoFormatado}");
            }

        } while (!StringTemConteudo || (documento.Length<14 || documento.Length>18));

    }
}