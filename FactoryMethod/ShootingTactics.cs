namespace DesignPatterns.FactoryMethod
{
    public interface IShootingTactics
    {
        Square NextTarget();
    }

    class RandomShooting : IShootingTactics
    {
        public Square NextTarget()
        {
            throw new NotImplementedException();
        }
    }

    class ZoneShooting : IShootingTactics
    {
        public Square NextTarget()
        {
            throw new NotImplementedException();
        }
    }

    class LineShooting : IShootingTactics
    {
        public Square NextTarget()
        {
            throw new NotImplementedException();
        }
    }
}
