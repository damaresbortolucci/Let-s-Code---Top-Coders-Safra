namespace Aula2._1_POO_Exercicios
{
    class Ex1_Retangulo
    {
        public static void Main(string[] args)
        {
            //Retangulo retangulo1 = new Retangulo();
            //retangulo1.altura = 10.5f;
            //retangulo1.largura = 15.0f;

            //Console.WriteLine("Dados do retângulo");
            //retangulo1.Mostrar();

            Retangulo[] retangulos = new Retangulo[10];

            for (int i = 0; i < 10; i++)
            {
                retangulos[i] = new Retangulo();

                Console.WriteLine($"\nRetangulo {i + 1}");
                Console.Write($"Altura: ");
                retangulos[i].altura = float.Parse(Console.ReadLine());

                Console.Write($"Largura: ");
                retangulos[i].largura = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n------- Resumo dos retângulos -------\n");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nRetângulo {i + 1}");
                retangulos[i].Mostrar();
            }
        }
    }
    
    class Retangulo
    {

        public float altura = 0;
        public float largura = 0;

        public void Mostrar()
        {
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Largura: {largura}");
        }
    }
}