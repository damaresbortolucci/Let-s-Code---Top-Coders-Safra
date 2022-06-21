
namespace Aula7_POO_Desafio4_2
{
    class AutomovelLuxo : Automovel
    {
        private bool direcaoHidraulica;
        private bool arCondicionado;
        private bool vidrosEletricos;

        public bool DirecaoHidraulica { get => direcaoHidraulica; set => direcaoHidraulica = value; }
        public bool ArCondicionado { get => arCondicionado; set => arCondicionado = value; }
        public bool VidrosEletricos { get => vidrosEletricos; set => vidrosEletricos = value; }

        public AutomovelLuxo(string? placa, string? modelo, int ano, string? cor, ECombustivel combustivel, bool direcaoHidraulica, bool arCondicionado, bool vidrosEletricos) : base(placa, modelo, ano, cor, combustivel)
        {
            DirecaoHidraulica = direcaoHidraulica;
            ArCondicionado = arCondicionado;
            VidrosEletricos = vidrosEletricos;
        }

        public override decimal CalculaValor()
        {
            decimal valorFinal = base.CalculaValor();

            if (DirecaoHidraulica)
                valorFinal += 1500m;
            if (ArCondicionado)
                valorFinal += 2000m;
            if (VidrosEletricos)
                valorFinal += 800m;

            return valorFinal;
        }

        public override void ImprimeDados()
        {
            base.ImprimeDados();
            Console.WriteLine($"Direção hidráulica: {DirecaoHidraulica}");
            Console.WriteLine($"Ar-condicionado: {ArCondicionado}");
            Console.WriteLine($"Vidros elétricos: {VidrosEletricos}");
        }
    }
}
