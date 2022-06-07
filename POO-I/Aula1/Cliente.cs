using System;


namespace Aula1_POO_Atributos
{

    class TesteCliente
    {
        public static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Dâmares";
            cliente1.codigo = 1;

            Cliente cliente2 = new Cliente();
            cliente2.nome = "Carlos Renato";
            cliente2.codigo = 2;

            Cliente cliente3 = new Cliente();
            cliente3.nome = "Reinaldo";
            cliente3.codigo = 3;


            Console.WriteLine("Cliente 1: " + cliente1.nome);
            Console.WriteLine("Cliente 2: " + cliente2.nome);
            Console.WriteLine("Cliente 3: " + cliente3.nome);

        }
    }


    class Cliente
    {
        public string? nome;
        public int codigo;
        public string? cpf;

        public bool validaCpf(string cpf)
        {
            bool cpfValido = false;

            if (string)
            {
                cpfValido = true;
            }
            return cpfValido;
        }
    }
}
