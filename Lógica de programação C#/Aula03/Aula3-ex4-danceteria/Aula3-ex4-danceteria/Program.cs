public class Program
{
    public static void Main()
    {

        //Em uma danceteria o preço da entrada sofre variações.Segundas, Terças e Quintas, ela oferece um 
        //desconto de 25 % do preço normal de entrada.Nos dias de músicas ao vivo, o preço da entrada ainda 
        //é acrescido em 15 % em relação ao preço normal da entrada. Faça um programa que leia o preço 
        //normal da entrada, o dia da semana,e se é dia de música ao vivo(“Sim”) ou não(“Não”). Calcular e 
        //imprimir o preço final que deverá ser pago pela entrada.


        Console.Write("Valor normal da entrada: R$ ");
        decimal valorNormal = decimal.Parse(Console.ReadLine());

        Console.Write("Dia da semana: ");
        string dia = Console.ReadLine().ToLower();

        Console.Write("É dia de música ao vivo? (sim/nao): ");
        string musica = Console.ReadLine().ToLower();

        decimal valorEntrada = 0M;

        if (dia == "segunda" || dia == "terca" || dia == "terça" || dia == "quinta")
        {
            if (musica == "sim")
                valorEntrada = (valorNormal - (valorNormal * 0.25M)) + (valorNormal * 0.15M);
            else if (musica == "nao" || musica == "não")
                valorEntrada = valorNormal - (valorNormal * 0.25M);
            else
                Console.WriteLine("Digite \"sim\" ou \"nao\"");
        }
        else if (dia == "quarta" || dia == "sexta" || dia == "sabado" || dia == "sábado" || dia == "domingo")
        {
            if (musica == "sim")
                valorEntrada = valorNormal + (valorNormal * 0.15M);
            else if (musica == "nao" || musica == "não")
                valorEntrada = valorNormal;
            else
                Console.WriteLine("Digite \"sim\" ou \"nao\"");
        }
        else
            Console.WriteLine("Informe um dia válido");

        Console.WriteLine($"Valor da entrada: {valorEntrada:C}");

    }
}
