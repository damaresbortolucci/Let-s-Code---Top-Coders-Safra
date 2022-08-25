public class Program
{
    public static void Main()
    {

        //Sabendo que somente os municípios que possuem mais de 20000 eleitores aptos têm segundo turno 
        //nas eleições para prefeito caso o primeiro colocado não tenha mais do que 50 % dos votos, 
        //fazendo um algoritmo que leia o nome do município, a quantidade de eleitores aptos, 
        //o número de votos do candidato mais votado e informar se ele terá ou não segundo turno em sua 
        //eleição municipal.Caso não tenha segundo turno, detalhe o motivo.


        string municipio;
        do
        {
            Console.Write("Nome do Município: ");
            municipio = Console.ReadLine();

            if (municipio == String.Empty)
            {
                Console.Clear();
                Console.WriteLine("Informe o nome do município");
            }
        } while (municipio == String.Empty);


        Console.Write("Número de eleitores aptos: ");
        int eleitores = int.Parse(Console.ReadLine());

        Console.Write("Número de votos do candidato mais votado: ");
        int votosCandidato = int.Parse(Console.ReadLine());

        double votosMinimos = (double)eleitores / 2;


        if (votosCandidato > eleitores)
            Console.Write("O número de votos não pode ser maior que o de eleitores.");
        else if (eleitores > 20000)
        {
            if (votosCandidato > votosMinimos)
                Console.WriteLine($"\nNão haverá segundo turno em {municipio}!\nO candidato obteve mais de 50% de votos válidos.");
            else
                Console.WriteLine($"\nHaverá segundo turno em {municipio}!\nO candidato não obteve mais de 50% dos votos válidos.");
        }
        else
            Console.WriteLine($"\nNão haverá segundo turno em {municipio}!\nO município não tem mais de 20.000 eleitores aptos.");


    }
}
