public class Program
{
    public static void Main()
    {

        Console.WriteLine("Informe o valor do salário");
        Console.Write("R$: ");
        decimal salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor da prestação");
        Console.Write("R$: ");
        decimal prestacao = decimal.Parse(Console.ReadLine());

        Console.WriteLine(prestacao > (salario * 0.20M) ? "\nEmpréstimo não concedido!" : "\nEmpréstimo concedido!");

    }
}
