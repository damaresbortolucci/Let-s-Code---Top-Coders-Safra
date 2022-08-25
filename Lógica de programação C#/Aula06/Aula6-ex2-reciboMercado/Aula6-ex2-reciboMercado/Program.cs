public class Program

{
    public static void Main()
    {

        Dictionary<string, decimal> produto = new Dictionary<string, decimal>();
        Dictionary<string, int> lista = new Dictionary<string, int>();
        decimal valorTotal = 0.0M;

        produto.Add("banana", 1.60M);
        produto.Add("maçã", 1.90M);
        produto.Add("pipoca", 4.20M);
        produto.Add("pão francês", 1.20M);
        produto.Add("coca-cola 2l", 10.00M);
        produto.Add("iogurte 1l", 6.30M);
        produto.Add("caixa de chocolate", 8.00M);
        produto.Add("amendoim", 3.75M);


        try
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\nNome do produto: ");
                string nome = Console.ReadLine().ToLower();
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                lista.Add(nome, quantidade);
            }

            Console.Clear();
            Console.WriteLine("Produto           | Qtde | Total");
            Console.WriteLine("-----------------------------------");

            foreach (string item in lista.Keys)
            {
                Console.WriteLine($"{item.PadRight(20)} {lista[item].ToString().PadRight(5)} {lista[item] * produto[item]:C}");
                valorTotal += lista[item] * produto[item];
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"\nValor total da compra: {valorTotal:C}");
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
