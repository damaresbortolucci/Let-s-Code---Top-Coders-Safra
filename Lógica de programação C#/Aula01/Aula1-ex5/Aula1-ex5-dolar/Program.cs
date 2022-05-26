using System.Globalization;

public class Program
{
    public static void Main()
    {
        decimal valorEmDolar=0;
        const decimal VALOR_DOLAR = 5.06M;
        bool valor;

        Console.WriteLine("CONVERSOR REAL PARA DOLAR");
        do
        {
            Console.Write("Valor em Real: R$ ");
            valor = decimal.TryParse(Console.ReadLine(), out decimal valorEmReal);
            if (valor)
                valorEmDolar = valorEmReal / VALOR_DOLAR;
       
        } while(!valor);

        Console.Write("Valor em Dolar: ");
        Console.WriteLine($"{valorEmDolar.ToString("C",CultureInfo.CreateSpecificCulture("en-us"))}");
    }
}