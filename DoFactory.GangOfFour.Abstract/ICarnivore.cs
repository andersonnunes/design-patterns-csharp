using System;

namespace DoFactory.GangOfFour.Abstract
{
    /// <summary>
    /// The 'AbstractProductB' interface
    /// </summary>
    interface ICarnivore
    {
        void Eat(IHerbivore h);
    }
}