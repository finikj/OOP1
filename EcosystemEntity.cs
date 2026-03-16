using System;

namespace ConsoleApp1
{
    public abstract class EcosystemEntity : IInteractable
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        protected EcosystemEntity(string name)
        {
            _name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Название: {Name}");
        }

        public abstract void Interact(EcosystemEntity other);
    }
}