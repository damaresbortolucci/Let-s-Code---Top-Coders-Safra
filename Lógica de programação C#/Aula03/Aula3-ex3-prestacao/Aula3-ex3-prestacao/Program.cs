public class Program
{
    public static void Main()
    {

        //A loja Mamão com Açúcar está vendendo seus produtos em cinco prestações sem juros, 
        //para compras até R$ 500,00 e em oito prestações sem juros, para compras acima de R$500,00.
        //Faça um programa que receba um valor de uma compra e mostre o valor das prestações.


        decimal valor;
        int parcelas = 0;
        bool validaValor;

        do
        {
            Console.WriteLine("Informe o valor da compra");
            Console.Write("R$: ");
            validaValor = decimal.TryParse(Console.ReadLine(), out valor);
            if (valor < 1)
                Console.Clear();
            Console.WriteLine("O valor não pode ser menor que R$ 1,00");
        } while (!validaValor || valor < 1M);


        if (valor <= 500)
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
}
