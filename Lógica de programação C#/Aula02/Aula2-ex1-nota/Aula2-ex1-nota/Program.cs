using System.Globalization;

public class Program
{
    public static void Main()
    {
        double media;
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        Console.WriteLine("*** Média de Notas ***");
        Console.Write("Informe a 1° nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Informe a 2° nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        if(nota1 <1.00 || nota1 > 10.00 || nota2 < 1.00 || nota2 > 10.00)
            Console.WriteLine("Nota inválida!");
        else
        {
            media = (nota1 + nota2) / 2;
            Console.WriteLine($"Média do aluno: {media}");
        }
    }
}