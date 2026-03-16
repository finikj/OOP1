using System;

namespace ConsoleApp1
{
    public class Mammal : Animal
    {
        private int _babiesCount;

        public int BabiesCount {get => _babiesCount; set => _babiesCount = value; }

        public Mammal(string nickname, string vid, int babiesCount) : base(nickname, vid)
        {
            _babiesCount = babiesCount;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество детенышей: {BabiesCount}");
            Console.WriteLine(new string('-', 30));
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Nickname} ({_vid}) издает звук млекопитающего");
        }

        public override void Move()
        {
            Console.WriteLine($"{Nickname} бежит");
        }
    }
}