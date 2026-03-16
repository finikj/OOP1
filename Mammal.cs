using System;

namespace ConsoleApp1
{
    public class Mammal
    {
        private string _nickname;
        private string _vid;
        private int _age;
        private int _weight;
        private int _babiesCount;
        private string _favoriteFood;
        public string Nickname {get => _nickname; set => _nickname = value;}
        public string Vid {get => _vid; set => _vid = value;}
        public int Age {get => _age; set => _age = value;}
        public int Weight {get => _weight; set => _weight = value;}
        public int BabiesCount {get => _babiesCount; set => _babiesCount = value;}
        public string FavoriteFood {get => _favoriteFood; set => _favoriteFood = value;}

        public Mammal(string nickname, string species, int age, int weight, int babiesCount, string favoriteFood)
        {
            _nickname = nickname;
            _vid = species;
            _age = age;
            _weight = weight;
            _babiesCount = babiesCount;
            _favoriteFood = favoriteFood;
        }

        public void Feed()
        {
            Weight++;
            Console.WriteLine($"{Nickname} поел и теперь весит {Weight}");
        }

        public void Osmotr()
        {
            if (Weight > 15)
            {
                Console.WriteLine($"{Nickname} слишком тяжелый, нужно похудеть");
            }
            else if (Weight < 10)
            {
                Console.WriteLine($"{Nickname} слишком легкий, нужно набрать вес");
            }
            else
            {
                Console.WriteLine($"{Nickname} в хорошем состоянии");
            }
        }

        public void Rodit(int babies)
        {
            BabiesCount += babies;
            Console.WriteLine($"{Nickname} родила {babies} детенышей, теперь у нее {BabiesCount} детенышей");
        }

        public void Print()
        {
            Console.WriteLine($"Кличка: {Nickname}");
            Console.WriteLine($"Вид: {Vid}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Вес: {Weight}");
            Console.WriteLine($"Количество детенышей: {BabiesCount}");
            Console.WriteLine($"Любимая еда: {FavoriteFood}");
        }
    }
}