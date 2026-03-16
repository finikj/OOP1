using System;

namespace ConsoleApp1
{
    public class Predator : EcosystemEntity
    {
        private int _strength;

        public int Strength
        {
            get => _strength;
            set => _strength = value;
        }

        public Predator(string name, int strength) : base(name)
        {
            _strength = strength;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сила: {Strength}");
            Console.WriteLine(new string('-', 30));
        }

        public override void Interact(EcosystemEntity other)
        {
            if (other is Herbivore)
            {
                Console.WriteLine($"{Name} охотится на {other.Name}");
            }
            else if (other is Plant)
            {
                Console.WriteLine($"{Name} игнорирует {other.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} конкурирует с {other.Name}");
            }
        }
    }
}