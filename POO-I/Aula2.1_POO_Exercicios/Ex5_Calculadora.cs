using System;

namespace Aula2._1_POO_Exercicios
{
    class Ex5_Calculadora
    {
        public static void Main(string[] args)
        {

            try
            {
                Calculadora cal1 = new Calculadora();

                Console.WriteLine("Informe o 1° número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o 2° número: ");
                double num2 = double.Parse(Console.ReadLine());

                if (num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Informe um número diferente de 0");
                    return;
                }

                Console.WriteLine("\n*** Resultados ***\n");

                Console.WriteLine($"Soma de {num1} e {num2} = {cal1.Somar(num1, num2)}");
                Console.WriteLine($"Subtração de {num1} e {num2} = {cal1.Subtrair(num1, num2)}");
                Console.WriteLine($"Multiplicação de {num1} e {num2} = {cal1.Multiplicar(num1, num2)}");
                Console.WriteLine($"Divisão de {num1} por {num2} = {cal1.Dividir(num1, num2)}");
                Console.WriteLine($"Potência de {num1} elevado a {num2} = {cal1.Potencia(Convert.ToInt32(num1), Convert.ToInt32(num2))}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Informe um número válido!");
            }
        }
    }

    class Calculadora
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }

        public double Subtrair(double x, double y)
        {
            return x - y;
        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public double Dividir(double x, double y)
        {
            return x / y;
        }

        public double Potencia(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }
}
