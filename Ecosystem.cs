using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Ecosystem<T> where T : EcosystemEntity, IInteractable
    {
        private readonly List<T> _entities = new List<T>();
        private static int _entitiesCount;

        public static int EntitiesCount { get => _entitiesCount;}

        public void AddEntity(T entity)
        {
            _entities.Add(entity);
            _entitiesCount++;
        }

        public T? FindByName(string name)
        {
            foreach (T entity in _entities)
            {
                if (string.Equals(entity.Name, name))
                {
                    return entity;
                }
            }

            return null;
        }

        public void SimulateInteractions()
        {
            for (int i = 0; i < _entities.Count; i++)
            {
                for (int j = 0; j < _entities.Count; j++)
                {
                    if (i != j)
                    {
                        _entities[i].Interact(_entities[j]);
                    }
                }
            }
        }
    }
}