
namespace Aula7_POO_Desafio3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Elevador elevador = new Elevador(6, 10);
            int opcao;

            try
            {
                do
                {
                    Console.WriteLine("\nELEVADOR LET'S CODE");
                    Console.WriteLine("1 - Entrar ");
                    Console.WriteLine("2 - Sair ");
                    Console.WriteLine("0 - Emergência! Parar elevador!");
                    Console.Write("Opção: ");
                    opcao = int.Parse(Console.ReadLine());


                    if (opcao != 0 && (opcao == 1 || opcao == 2))
                    {
                        Console.Write("N° de pessoas: ");
                        int qtde = int.Parse(Console.ReadLine());

                        if (opcao == 1)
                            elevador.Entrar(qtde);
                        else
                            elevador.Sair(qtde);


                        if (elevador.PessoasPresentes > 0)
                        {
                            Console.Write("Próximo andar: ");
                            elevador.Deslocar(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine($"Pessoas presentes: {elevador.PessoasPresentes}");
                    }
                    else
                        Console.WriteLine("Informe um número válido");
                } while (opcao != 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Informe uma opção válida");
            }
        }
    }
}
