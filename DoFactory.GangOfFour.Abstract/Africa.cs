using System;

namespace DoFactory.GangOfFour.Abstract
{
    /// <summary>
    /// The 'ConcreteFactory1' class.
    /// </summary>
    class Africa : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}