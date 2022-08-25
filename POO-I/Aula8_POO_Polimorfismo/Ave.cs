
namespace Aula8_POO_Polimorfismo
{
    class Ave : Animal
    {
        public Ave(string animal) : base(animal){}

        public override void Mover()
        {
            Console.WriteLine("Voou");
        }
    }
}
