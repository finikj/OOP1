using System;

namespace ConsoleApp1
{
    public class Plant : EcosystemEntity
    {
        public Plant(string name) : base(name) {}
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Тип: растение");
            Console.WriteLine(new string('-', 30));
        }

        public override void Interact(EcosystemEntity other)
        {
            if (other is Herbivore)
            {
                Console.WriteLine($"{Name} служит пищей для {other.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} не реагирует на {other.Name}");
            }
        }
    }
}