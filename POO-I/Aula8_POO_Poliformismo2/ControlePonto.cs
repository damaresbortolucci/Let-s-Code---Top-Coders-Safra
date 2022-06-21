namespace Aula8_POO_Poliformismo2
{
    class ControlePonto
    {
        public void RegistrarEntrada(Funcionario funcionario)
        {
            DateTime data = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss", data);

            //Console.WriteLine("Entrada: " + funcionario.codigo);
            Console.WriteLine("Data: " + horario);
        }

        public void RegistrarSaida(Funcionario funcionario)
        {
            DateTime data = DateTime.Now;
            string horario = String.Format("{0:d/M/yyyy HH:mm:ss", data);

            //Console.WriteLine("Saída: " + funcionario.codigo);
            Console.WriteLine("Data: " + horario);
        }
    }
}