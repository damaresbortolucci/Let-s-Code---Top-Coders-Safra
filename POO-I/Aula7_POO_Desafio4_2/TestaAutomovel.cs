namespace Aula7_POO_Desafio4_2
{
    class TestaAutomovel
    {
        static void Main(string[] args)
        {
            Automovel auto = new Automovel("DBS4505", "Hyundai HB20", 2020, "preto", ECombustivel.ALCOOL);
            AutomovelLuxo autoLuxo = new AutomovelLuxo("JKL2332", "Fiat Mobi", 2022, "vermelho", ECombustivel.GASOLINA, true, true, false);


            Console.WriteLine("Dados do automóvel comum");
            auto.ImprimeDados();
            Console.WriteLine($"Valor: {auto.CalculaValor():c}");

            Console.WriteLine();

            Console.WriteLine("Dados do automóvel luxo");
            autoLuxo.ImprimeDados();
            Console.WriteLine($"Valor: {autoLuxo.CalculaValor():c}");
        }
    }
}