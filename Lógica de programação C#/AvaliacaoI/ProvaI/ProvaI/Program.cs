using System.Globalization;


//ex01();
//ex02();
//ex03();
//ex04();
//ex05();


static void ex01()
{

    //Leia a idade e o tempo de serviço de um trabalhador e escreva se ele pode ou não se aposentar. As condições para aposentadoria são Ter pelo menos 65 anos, Ou ter trabalhado pelo menos 30 anos, Ou ter pelo menos 60 anos e trabalhado pelo menos 25 anos


    try
    {
        Console.WriteLine("Informe a idade do trabalhador:");
        uint idade = uint.Parse(Console.ReadLine());

        Console.WriteLine("Informe o tempo de serviço em anos: ");
        uint tempoServico = uint.Parse(Console.ReadLine());

        if (idade >= 65 || tempoServico >= 30 || (idade >= 60 && tempoServico >= 25))
            Console.WriteLine("O trabalhador pode se aposentar");
        else
            Console.WriteLine("O trabalhador ainda não pode se aposentar");
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Informe um número inteiro válido");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exceção: {e.GetType().Name}");
        Console.WriteLine($"Mensagem: {e.Message}");
    }
}



static void ex02()
{

    //Faça uma prova de matemática para crianças que estão aprendendo a somar números inteiros menores do que 100.Escolha números aleatórios entre 1 e 100, e mostre na tela a pergunta: qual é a soma de a + b, onde a e b são os números aleatórios. Peça a resposta. Faça cinco perguntas ao aluno, e mostre para ele as perguntas e as respostas corretas, além de quais o aluno acertou.


    List<int> numA = new List<int>();
    List<int> numB = new List<int>();
    List<int> result = new List<int>();
    List<int> resposta = new List<int>();

    try
    {
        for (int i = 0; i < 5; i++)
        {
            int numeroA = retornaNumRandomA();
            int numeroB = retornaNumRandomB();
            result.Add(numeroA + numeroB);

            Console.Write($"\nQual é a soma de {numeroA} + {numeroB} = ");

            int resultado = int.Parse(Console.ReadLine());
            resposta.Add(resultado);
        }

        Console.WriteLine("\n**** Resultado ****\n");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"A soma de {numA[i]} + {numB[i]} é: {result[i]}");

            if (resposta[i] == result[i])
                Console.WriteLine("Você acertou!");
            else
                Console.WriteLine("Você errou!");
        }


        int retornaNumRandomA()
        {
            Random randNumA = new Random();
            int numeroA = randNumA.Next(1, 100);
            numA.Add(numeroA);
            return numeroA;
        }

        int retornaNumRandomB()
        {
            Random randNumB = new Random();
            int numeroB = randNumB.Next(1, 100);
            numB.Add(numeroB);
            return numeroB;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Informe um número inteiro válido");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exceção: {e.GetType().Name}");
        Console.WriteLine($"Mensagem: {e.Message}");
    }
}



static void ex03()
{

    //Faça um programa que calcula as áreas das seguintes figuras geométricas:

    //Área do quadrado.
    //Área do retângulo.
    //Área do triângulo.
    //Área do trapézio.

    //Baseado na escolha do usuário, você deverá pedir os valores necessários para fazer os cálculos (cm) e imprimir o nome da figura escolhida e o valor área para o usuário (cm²)


    try
    {
        double area;

        Console.WriteLine("Selecione o número da figura que deseja calcular a área?");
        Console.WriteLine("1 - Área do quadrado.");
        Console.WriteLine("2 - Área do retângulo.");
        Console.WriteLine("3 - Área do triângulo.");
        Console.WriteLine("4 - Área do trapézio.");
        Console.Write("Opção: ");

        int figura = int.Parse(Console.ReadLine());

        switch (figura)
        {
            case 1:
                Console.Write("Informe a medida do lado do quadrado (cm): ");
                double lado = double.Parse(Console.ReadLine());

                area = lado * lado;
                Console.WriteLine($"A área do quadrado é: {area}cm²");
                break;
            case 2:
                Console.Write("Informe a medida da base (cm): ");
                double baseRetangulo = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura (cm): ");
                double altura = double.Parse(Console.ReadLine());

                area = baseRetangulo * altura;
                Console.WriteLine($"A área do retâgulo é: {area}cm²");
                break;
            case 3:
                Console.Write("Informe a medida da base (cm): ");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura (cm): ");
                double alturaTriangulo = double.Parse(Console.ReadLine());

                area = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine($"A área do triângulo é: {area}cm²");
                break;
            case 4:
                Console.Write("Informe a medida da base maior (cm): ");
                double baseMaior = double.Parse(Console.ReadLine());
                Console.Write("Informe a medida da base menor (cm): ");
                double baseMenor = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura (cm): ");
                double alturaTrapezio = double.Parse(Console.ReadLine());

                area = ((baseMaior + baseMenor) * alturaTrapezio) / 2;
                Console.WriteLine($"A área do trapézio é: {area}cm²");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
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



static void ex04()
{

    //Faça um programa que receba o lucro de uma obra A de 400 m². Sabe - que o lucro de uma obra B de 200 m² equivale a um terço do valor da obra A de 400 m². A empresa irá aplicar o lucro da Obra A integralmente na caderneta de poupança que está rendendo 2 % ao mês.Já o lucro da Obra B será aplicado integralmente em um fundo de renda fixa que está rendendo 5 % ao mês.Calcule a quantidade de meses necessários para o que o lucro aplicado da Obra B seja maior ou igual ao lucro aplicado da Obra A.


    try
    {
        Console.WriteLine("Obra A com 400m²");
        Console.Write("Informe o valor do lucro da obra A: R$ ");
        decimal lucroA = decimal.Parse(Console.ReadLine());

        decimal carteiraA = lucroA;
        decimal lucroB = lucroA / 3;
        decimal carteiraB = lucroB;
        int meses = 0;

        while (carteiraB < carteiraA)
        {
            carteiraA += carteiraA * 0.02M;
            carteiraB += carteiraB * 0.05M;
            meses++;
        }

        Console.WriteLine($"Foram necessários {meses.ToString()} meses para a carteira do imóvel B ultrapassar A.");

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



static void ex05()
{

//Regras: Não utilize condicionais(if ou switch) para encontrar a aliquota do estado

//Uma empresa vende o mesmo produto para diferentes estados. Cada estado possui uma taxa diferente de imposto sobre o produto (MG 7%; SP 12 %; RJ 15 %; MS 8 %; ES 12 %; SC 18 %;). Faça um programa em que o usuário entre com o valor e o estado de destino do produto e o programa retorne o preço final do produto acrescido do imposto do estado em que ele será vendido. Se o estado digitado não for válido, mostrar uma mensagem de erro.


    decimal valorFinal;
    Dictionary<string, decimal> aliquota = new Dictionary<string, decimal>();

    aliquota.Add("MG", 0.07m);
    aliquota.Add("SP", 0.12m);
    aliquota.Add("RJ", 0.15m);
    aliquota.Add("MS", 0.08m);
    aliquota.Add("ES", 0.12m);
    aliquota.Add("SC", 0.18m);


    try
    {
        Console.Write("Valor do produto: R$ ");
        decimal valor = decimal.Parse(Console.ReadLine());

        Console.Write("Estado para envio: ");
        string estado = Console.ReadLine().ToUpper();


        if (aliquota.ContainsKey(estado))
        {
            foreach (string chave in aliquota.Keys)
            {
                if (chave == estado)
                {
                    valorFinal = valor + (valor * aliquota[chave]);
                    Console.Write($"\nValor final: {valorFinal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}\n");
                }
            }
        }
        else
            Console.WriteLine("O Estado informado não é válido");
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
