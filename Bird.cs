using System;

namespace ConsoleApp1
{
    public class Bird : Animal
    {
        private double _razmah;

        public double Razmah
        {
            get => _razmah;
            set => _razmah = value;
        }

        public Bird(string nickname, string vid, double razmah)
            : base(nickname, vid)
        {
            _razmah = razmah;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Размах крыльев: {Razmah}");
            Console.WriteLine(new string('-', 30));
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Nickname} ({_vid}) поет");
        }

        public override void Move()
        {
            Console.WriteLine($"{Nickname} летит");
        }
    }
}