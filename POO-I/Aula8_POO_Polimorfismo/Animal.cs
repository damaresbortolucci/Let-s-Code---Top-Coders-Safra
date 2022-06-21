namespace Aula8_POO_Polimorfismo
{
    class Animal
    {
        public string tipo;

        public Animal(string animal)
        {
            this.tipo = animal;
        }

        public virtual void Mover() {

            Console.WriteLine("Animal andou");
        }
    }
}