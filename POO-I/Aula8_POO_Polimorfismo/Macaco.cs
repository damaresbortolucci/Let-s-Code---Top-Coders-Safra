
namespace Aula8_POO_Polimorfismo
{
    class Macaco : Animal
    {
        public Macaco(string animal) : base(animal){}

        public override void Mover()
        {
            Console.WriteLine("Pulou");
        }
    }
}
