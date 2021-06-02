using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Gunnery
    {
        private TacticsFactory tacticsFactory = new TacticsFactory();
        private ITargetSelect targetSelect;

        private void ChangeTactics(ShootingTactics tactics)
        {
            targetSelect = tacticsFactory.CreateTactics(tactics);
        }
    }

    struct Square
    { }

    interface ITargetSelect
    {
        Square NextTarget();
    }

    class RandomShooting : ITargetSelect
    {
        public Square NextTarget()
        {
            throw new NotImplementedException();
        }
    }

    class SurroundingShooting : ITargetSelect
    {
        public Square NextTarget()
        {
            throw new NotImplementedException();
        }
    }

    class LinearShooting : ITargetSelect
    {
        public Square NextTarget()
        {
            throw new NotImplementedException();
        }
    }

    enum ShootingTactics
    {
        Random,
        Surrounding,
        Linear
    }

    class TacticsFactory
    {
        public ITargetSelect CreateTactics(ShootingTactics tactics)
        {
            switch (tactics)
            {
                case ShootingTactics.Random:
                    return new RandomShooting();
                case ShootingTactics.Surrounding:
                    return new SurroundingShooting();
                case ShootingTactics.Linear:
                    return new LinearShooting();
                default:
                    throw new NotImplementedException();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
