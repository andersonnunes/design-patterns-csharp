using System;

namespace DoFactory.GangOfFour.Abstract
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        IHerbivore herbivore;
        ICarnivore carnivore;
        T factory;

        /// <summary>
        /// Contructor of Animalworld
        /// </summary>
        public AnimalWorld()
        {
            // Create new continent factory
            factory = new T();

            // Factory creates carnivores and herbivores
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        /// <summary>
        /// Runs the foodchain: carnivores are eating herbivores.
        /// </summary>
        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}