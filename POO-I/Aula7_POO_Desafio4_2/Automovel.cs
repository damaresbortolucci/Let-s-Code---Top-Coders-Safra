
namespace Aula7_POO_Desafio4_2
{
    class Automovel
    {
        private string? placa;
        private string? modelo;
        private int ano;
        private string? cor;
        private ECombustivel combustivel;

        public string? Placa { get => placa; set => placa = value; }
        public string? Modelo { get => modelo; set => modelo = value; }
        public int Ano { get => ano; set => ano = value; }
        public string? Cor { get => cor; set => cor = value; }
        public ECombustivel Combustivel { get => combustivel; set => combustivel = value; }

        public Automovel(string? placa, string? modelo, int ano, string? cor, ECombustivel combustivel)
        {
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Combustivel = combustivel;
        }

        public virtual decimal CalculaValor()
        {
            decimal valor = 0.0m;

            switch (this.Combustivel)
            {
                case ECombustivel.GASOLINA:
                    valor = 12000m;
                    break;
                case ECombustivel.ALCOOL:
                    valor = 10500m;
                    break;
                case ECombustivel.DIESEL:
                    valor = 11000m;
                    break;
                case ECombustivel.GAS:
                    valor = 13000m;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return valor;        
        }

        public virtual void ImprimeDados()
        {
            Console.WriteLine($"Placa: {Placa}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Combustível: {Combustivel}");
        }
    }

    enum ECombustivel
    {
        GASOLINA = 1,
        ALCOOL = 2,
        DIESEL = 3,
        GAS = 4
    }
}
