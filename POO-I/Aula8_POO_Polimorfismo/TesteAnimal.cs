
namespace Aula8_POO_Polimorfismo
{
    class TesteAnimal
    {
        public static void Main(string[] args)
        {
            Animal[] animais = new Animal[3];

            animais[0] = new Peixe("Carpa");
            animais[1] = new Macaco("Mico");
            animais[2] = new Ave("Pombo");

            foreach (Animal animal in animais)
            {
                MoverAnimal(animal);
            }
        }

        public static void MoverAnimal(Animal animal)
        {
            Console.WriteLine(animal.tipo);
            animal.Mover();
        }
    }
}
