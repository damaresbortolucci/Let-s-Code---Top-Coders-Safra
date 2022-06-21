namespace Aula7_POO_Desafio3
{
    class Elevador
    {
        private int andarAtual;
        private int pessoasPresentes;
        public int capacidade;
        public int andares;

        public int AndarAtual { get => andarAtual; set => andarAtual = value; }
        public int PessoasPresentes { get => pessoasPresentes; set => pessoasPresentes = value; }


        public Elevador(int capacidade, int andares)
        {
            this.capacidade = capacidade;
            this.andares = andares;
            AndarAtual = 0;
            PessoasPresentes = 0;
        }


        public void Entrar(int quantidade)
        {
            if ((quantidade + PessoasPresentes) <= this.capacidade)
            {
                PessoasPresentes += quantidade;
            }
            else if(PessoasPresentes == 6)
            {
                Console.WriteLine("O elevador já está lotado");
            }
            else
            {
                int pessoasPossiveis = this.capacidade - PessoasPresentes;
                PessoasPresentes += pessoasPossiveis;
                Console.WriteLine($"Somente {pessoasPossiveis} pessoas puderam entrar");
            }
        }


        public void Sair(int quantidade)
        {
            if(PessoasPresentes >= quantidade)
            {
                PessoasPresentes -= quantidade;
            }
            else
            {
                PessoasPresentes = 0; 
                Console.WriteLine($"Todas as pessoas presentes saíram do elevador\n");
            }
        }


        private void Subir(int andar)
        {
            AndarAtual += (andar - AndarAtual);
        }


        private void Descer(int andar)
        {
            AndarAtual -= (AndarAtual - andar);
        }


        public void Deslocar(int andar)
        {
            if (andar < 0 || andar > this.andares)
            {
                throw new ArgumentOutOfRangeException("Selecione o andar correto.");
            }  
            else if (andar < AndarAtual)
            {
                for (int i=AndarAtual; i >= andar; i--)
                {
                    DesenhaElevador(i, "descer");
                }
                Descer(andar);
            }
            else if (andar > AndarAtual)
            {
                for (int i = AndarAtual; i <= andar; i++)
                {
                    DesenhaElevador(i, "subir");
                }
                Subir(andar); 
            }
            else
                Console.WriteLine("Você já está no andar desejado");

            Console.WriteLine("------------------");
            Console.WriteLine("     Chegamos!");
            Console.WriteLine("------------------");
        }


        public void DesenhaElevador(int i, string op)
        {
            Console.Clear();
            Console.WriteLine(" _________________");
            if(op == "subir")
                if(i !=10)
                    Console.WriteLine($"|       ▲ {i}       |");
                else
                    Console.WriteLine($"|       ▲ {i}      |");
            else
                Console.WriteLine($"|       ▼ {i}       |");
            Console.WriteLine("|_________________|");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|        |        |");
            Console.WriteLine("|________|________|");
            Thread.Sleep(350);
        }
    }
}