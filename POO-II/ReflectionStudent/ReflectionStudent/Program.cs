using System.Reflection;
using Sharprompt;

namespace ReflectionStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayPublicProperties();

            Console.WriteLine();

            var name = Prompt.Input<string>("Digite o nome do aluno");
            var university = Prompt.Input<string>("Digite a Universidade");
            var rollNumber = Prompt.Input<int>("Digite o Roll Number");

            CreateInstance(name, university, rollNumber);
        }


        static void DisplayPublicProperties()
        {
            PropertyInfo[] properties = typeof(Student).GetProperties();

            Console.WriteLine("Relação de propriedades públicas:");
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}, do tipo '{property.PropertyType.Name}'");
            }
        }


        static void CreateInstance(string name, string university, int rollNumber)
        {
            Type type = typeof(Student);
            var student = (Student)Activator.CreateInstance(type);

            student.Name = name;
            student.University = university;
            student.RollNumber = rollNumber;

            //Outro método seguindo exemplo que está no Class:

            //foreach (var prop in type.GetProperties())
            //{
            //    if (prop.Name == "Name")
            //        prop.SetValue(student, name);
            //    else if (prop.Name == "University")
            //        prop.SetValue(student, university);
            //    else if (prop.Name == "RollNumber")
            //        prop.SetValue(student, rollNumber);
            //}

            student.DisplayInfo();
        }
    }
}