using System;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        private string _nickname;
        protected string _vid;

        public string Nickname { get => _nickname; set => _nickname = value; }
        public string Vid { get => _vid; protected set => _vid = value;}

        protected Animal(string nickname, string vid)
        {
            _nickname = nickname;
            _vid = vid;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Кличка: {Nickname}");
            Console.WriteLine($"Вид: {Vid}");
        }

        public abstract void MakeSound();

        public virtual void Move()
        {
            Console.WriteLine($"{Nickname} движется");
        }
    }
}