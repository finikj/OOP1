using System;

namespace ConsoleApp1
{
    public class Fish : Animal
    {
        private string _waterType;

        public string WaterType
        {
            get => _waterType;
            set => _waterType = value;
        }

        public Fish(string nickname, string vid, string waterType)
            : base(nickname, vid)
        {
            _waterType = waterType;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Тип воды: {WaterType}");
            Console.WriteLine(new string('-', 30));
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Nickname} ({_vid}) булькает");
        }

        public override void Move()
        {
            Console.WriteLine($"{Nickname} плывет");
        }
    }
}