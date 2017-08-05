using System;

namespace DoFactory.GangOfFour.Abstract
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    interface IContinentFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}