public class Program
{
    public static void Main()
    {

        /*A loja Mamão com Açúcar está vendendo seus produtos em cinco prestações sem juros, para compras 
         * até R$ 500,00 e em oito prestações sem juros, para compras acima de R$500,00. Faça um programa 
         * que receba um valor de uma compra e mostre o valor das prestações.*/

        decimal valor;
        int parcelas = 0;

        try
        {
            Console.WriteLine("Valor da compra");
            Console.Write("R$: ");
            valor = decimal.Parse(Console.ReadLine());

            if (valor < 1)
                Console.WriteLine("O valor não pode ser menor que R$ 1,00");
            else if (valor <= 500)
                parcelas = 5;
            else
                parcelas = 8;


            decimal prestacao = Math.Round(valor / parcelas, 2);
            decimal resto = valor - (prestacao * parcelas);

            if (resto == 0M)
            {
                Console.WriteLine($"Valor das prestações:");
                Console.WriteLine($"{parcelas}x R$ {prestacao:C}");

            }
            else
            {
                Console.WriteLine($"Valor das prestações:");
                Console.WriteLine($"1x R$ {prestacao + resto:C}");
                Console.WriteLine($"4x R$ {prestacao:C}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Informe um valor válido");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Exceção: {e.GetType().Name}");
            Console.WriteLine($"Mensagem: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exceção: {e.GetType().Name}");
            Console.WriteLine($"Mensagem: {e.Message}");
        }

    }
}
