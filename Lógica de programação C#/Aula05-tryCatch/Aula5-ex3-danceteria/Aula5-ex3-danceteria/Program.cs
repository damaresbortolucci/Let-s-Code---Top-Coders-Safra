public class Program
{
    public static void Main()
    {

        /*Em uma danceteria o preço da entrada sofre variações. Segundas, Terças e Quintas, ela oferece 
         * um desconto de 25% do preço normal de entrada. Nos dias de músicas ao vivo, o preço da entrada 
         * ainda é acrescido em 15% em relação ao preço normal da entrada. Faça um programa que leia o preço 
         * normal da entrada, o dia da semana,e se é dia de música ao vivo (“Sim”) ou não (“Não”). Calcular 
         * e imprimir o preço final que deverá ser pago pela entrada.*/


        decimal valorEntrada = 0M;

        try
        {
            Console.Write("Valor normal da entrada: R$ ");
            decimal valorNormal = decimal.Parse(Console.ReadLine());

            Console.Write("Dia da semana: ");
            string dia = Console.ReadLine().ToLower();

            Console.Write("É dia de música ao vivo? (sim/nao): ");
            string musica = Console.ReadLine().ToLower();


            if (dia == null || dia == string.Empty)
                throw new ArgumentNullException("o dia");
            if (musica == null || musica == string.Empty)
                throw new ArgumentNullException("se tem música ao vivo");


            if (dia == "segunda" || dia == "terca" || dia == "quinta")
            {
                if (musica == "sim")
                    valorEntrada = (valorNormal - (valorNormal * 0.25M)) + (valorNormal * 0.15M);
                else
                    valorEntrada = valorNormal - (valorNormal * 0.25M);
            }
            else if (dia == "quarta" || dia == "sexta" || dia == "sabado" || dia == "domingo")
            {
                if (musica == "sim")
                    valorEntrada = valorNormal + (valorNormal * 0.15M);
                else
                    valorEntrada = valorNormal;
            }
            else
                Console.WriteLine("Informe um dia válido");

            Console.WriteLine($"Valor da entrada: {valorEntrada:C}");

        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"Por favor, informe {e.ParamName}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Informe um valor válido");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exceção: {e.GetType().Name}");
            Console.WriteLine($"Mensagem: {e.Message}");
        }

    }
}
