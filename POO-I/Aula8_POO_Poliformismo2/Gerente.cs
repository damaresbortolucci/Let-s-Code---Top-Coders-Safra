
namespace Aula8_POO_Poliformismo2
{
    class Gerente : Funcionario
    {
        private string? usuario;
        private string? senha;


        public Gerente(string nome, decimal salario, string usuario, string senha) : base(nome, salario)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
            }
        }

        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
            }
        }

        public override decimal Bonificacao()
        {
            return Salario * 0.2m ;
        }

        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Usuário: {Usuario}");
            Console.WriteLine($"Senha: {Senha}");
        }
    }
}
