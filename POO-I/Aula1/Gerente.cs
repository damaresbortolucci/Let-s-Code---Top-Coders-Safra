
namespace Aula1_POO_Atributos
{
    class TesteGerente
    {
        public static void Main(string[] args)
        {
            //Exemplo Construtor 1
            Gerente ge1 = new Gerente("Joaquim Oliveira");
            ge1.salario = 5000;

            //Exemplo Construtor 2
            Gerente ge2 = new Gerente("Luiz Carlos Santos", 6000);
     

            Console.WriteLine("Salário: " + ge1.salario);

            Console.WriteLine("Aumentar Salário em 10%");
            ge1.AumentaSalario();
            Console.WriteLine("Salario Atual com 10%: " + ge1.salario);

            Console.WriteLine("Aumenta salário em 50%");
            ge1.AumentaSalario(0.5);
            Console.WriteLine("Salario Atual com 50%: " + ge1.salario);

            double novoSalarioSBonus = ge1.AumentaSalario1(0.25);
            ge1.AplicaBonus(novoSalarioSBonus);
            Console.WriteLine("Bonificação: " + ge1.salario);
        }
    }


    class Gerente
    {
        public string? nome;
        public double salario;

        public Gerente(string? nome)    
        {
            this.nome = nome;
        }

        public Gerente(string? nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }


        public void AumentaSalario()
        {
            this.AumentaSalario(0.1);
        }

        public void AumentaSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }

        public double AumentaSalario1(double taxa)
        {
            double novoSalario = this.salario += this.salario * taxa;
            return novoSalario;
        }

        public void AplicaBonus(double salarioSBonus)
        {
            this.salario = salarioSBonus + 1000;
        }


        public void TiraFerias(int dias)
        {
            Console.WriteLine($"Férias parciais de {dias} dias concedidas");
            Console.WriteLine($"Abono: R$ {this.salario / 3}");
        }

        public void TiraFerias()
        {
            Console.WriteLine("Férias de 30 dias concedidas");
            Console.WriteLine($"Abono: R$ {this.salario/3}");
        }


        public double RecebeComissao(double vendas)
        {
            return RecebeComissao(vendas, 0.15);
        }

        public double RecebeComissao(double vendas, double taxa)
        {
            return vendas * taxa;
        }
    }
}
