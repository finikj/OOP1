using System;

namespace ConsoleApp1
{
    public class Herbivore : EcosystemEntity
    {
        private int _speed;
        public int Speed {get => _speed; set => _speed = value;}
        public Herbivore(string name, int speed) : base(name)
        {
            _speed = speed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine(new string('-', 30));
        }

        public override void Interact(EcosystemEntity other)
        {
            if (other is Plant)
            {
                Console.WriteLine($"{Name} ест {other.Name}");
            }
            else if (other is Predator)
            {
                Console.WriteLine($"{Name} убегает от {other.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} спокойно взаимодействует с {other.Name}");
            }
        }
    }
}