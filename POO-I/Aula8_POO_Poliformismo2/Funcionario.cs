
namespace Aula8_POO_Poliformismo2
{
    class Funcionario
    {
        private string? nome;
        private decimal salario;

        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
            }
        }

        public decimal Salario
        {
            get { return salario; }
            set
            {
                salario = value;
            }
        }

        public virtual decimal Bonificacao()
        {
            return salario * 0.1m;
        }


        public virtual void MostraDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: {Salario:C}");
            Console.WriteLine($"Bonificação: {Bonificacao():C}");
        }
    }
}
