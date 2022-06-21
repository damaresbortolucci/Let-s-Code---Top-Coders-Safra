
namespace Aula8_POO_Polimorfismo
{
    class Peixe : Animal
    {
        public Peixe(string animal) : base(animal){}

        public override void Mover()
        {
            Console.WriteLine("Nadou");
        }
    }
}
