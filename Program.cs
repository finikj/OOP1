using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main()
        {
            Ecosystem<EcosystemEntity> ecosystem = new Ecosystem<EcosystemEntity>();

            ecosystem.AddEntity(new Predator("волк", 9));
            ecosystem.AddEntity(new Herbivore("олень", 14));
            ecosystem.AddEntity(new Plant("трава"));

            Console.WriteLine("SimulateInteractions():");
            ecosystem.SimulateInteractions();

            Console.WriteLine("FindByName():");
            EcosystemEntity? foundEntity = ecosystem.FindByName("волк");

            if (foundEntity != null)
            {
                foundEntity.Print();
            }
            else
            {
                Console.WriteLine("сущность не найдена");
            }

            Console.WriteLine($"всего сущностей: {Ecosystem<EcosystemEntity>.EntitiesCount}");
        }
    }
}