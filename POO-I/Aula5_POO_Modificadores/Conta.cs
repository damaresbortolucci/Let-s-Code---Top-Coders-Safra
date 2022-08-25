namespace Aula5_POO_Modificadores
{
    public class Conta
    {
        // ATRIBUTOS
        private decimal saldo;
        private decimal limite;


        // PROPRIEDADES
        public decimal Saldo 
        { 
            get 
            { 
                return saldo; 
            } 
            set 
            {
                if (saldo < 10000)
                    saldo = value;
                else
                    throw new ArgumentException("Saldo....");
            } 
        }
    }
}