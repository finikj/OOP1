using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Mammal("Рекс", "собака", 4));
            animals.Add(new Bird("Кеша", "попугай", 0.5));
            animals.Add(new Fish("Немо", "рыба", "морская"));

            Console.WriteLine("Print():");
            foreach (Animal animal in animals)
            {
                animal.Print();
            }

            Console.WriteLine("MakeSound():");
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine("Move():");
            foreach (Animal animal in animals)
            {
                animal.Move();
            }
        }
    }
}