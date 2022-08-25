public class Program

{
    public static void Main()
    {

        //Um cliente realizou um investimento inicial de R$ 250.000,00 em um fundo de investimento.

        //1) Receba o rendimento do fundo (em %) ao longo dos últimos 6 meses e armazene
        //   os valores em um array.
        //2) Calcule para cada mês o valor em carteira(R$) de acordo com o rendimento.
        //   Imprima o valor da carteira, mês a mês, nos últimos 6 meses.
        //3) Encontre o mês em que ocorreu o maior valor da carteira. Imprima mês e o valor.
        //4) Encontre o mês em que ocorreu o menor valor da carteira. Imprima mês e o valor.
        //5) Conte o número de meses em que o valor da carteira superou o aporte inicial.

        decimal[] porcentagem = new decimal[6] { 0, 0, 0, 0, 0, 0 };
        decimal[] valorEmCarteira = new decimal[6] { 0, 0, 0, 0, 0, 0 };
        decimal investimento = 250000.00M;
        int meses = 0;

        try
        {
            for (int i = 0; i < porcentagem.Length; i++)
            {
                Console.Write($"Rendimento (%) no {i + 1}° mês: ");
                porcentagem[i] = decimal.Parse(Console.ReadLine());

                if (i != 0)
                    valorEmCarteira[i] = valorEmCarteira[i - 1] + (valorEmCarteira[i - 1] * porcentagem[i]);
                else
                    valorEmCarteira[0] = investimento + (investimento * porcentagem[0]);

                if (valorEmCarteira[i] > investimento)
                    meses++;

                Console.WriteLine($"Valor em carteira: {valorEmCarteira[i]:C}\n");
            }


            Console.WriteLine("\nRelátorio de rendimentos\n");

            for (int i = 0; i < porcentagem.Length; i++)
            {
                Console.WriteLine($"Valor em carteira no {i + 1}° mês: R$ {valorEmCarteira[i]:C}");
            }


            int mesMaiorRend = 0;
            int mesMenorRend = 0;
            decimal maxValue = decimal.MinValue;
            decimal minValue = decimal.MaxValue;

            for (int i = 0; i <= 5; i++)
            {
                if (valorEmCarteira[i] > maxValue)
                {
                    mesMaiorRend = i + 1;
                    maxValue = valorEmCarteira[i];
                }

                if (valorEmCarteira[i] < minValue)
                {
                    mesMenorRend = i + 1;
                    minValue = valorEmCarteira[i];
                }
            }

            Console.Write($"\nO mês com MAIOR rendimento foi o {mesMaiorRend}° mês com R${valorEmCarteira[(mesMaiorRend - 1)]:C}");
            Console.Write($"\nO mês com MENOR rendimento foi o {mesMenorRend}° mês com R${valorEmCarteira[(mesMenorRend - 1)]:C}");

            if (meses > 0)
                Console.Write($"\nQuantidade de meses em que o valor da carteira superou o aporte inicial: {meses}\n");
            else
                Console.WriteLine($"Em todos os meses o valor da carteira ficou abaixo do aporte inicial");
        }
        catch (FormatException)
        {
            Console.WriteLine("Informe uma porcentagem válida");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exceção: {e.GetType().Name}");
            Console.WriteLine($"Mensagem: {e.Message}");
        }

    }
}
