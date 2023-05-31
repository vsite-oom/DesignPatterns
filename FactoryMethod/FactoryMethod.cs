namespace DesignPatterns.FactoryMethod
{
    public class ShootingTacticsFactory
    {
        public IShootingTactics Create(CurrentShootingTactics shootingTactics)
        {
            switch (shootingTactics)
            {
                case CurrentShootingTactics.Random:
                    return new RandomShooting();
                case CurrentShootingTactics.Zone:
                    return new ZoneShooting();
                case CurrentShootingTactics.Line:
                    return new LineShooting();
                default:
                    return null;
            }
        }


    }
    internal class Program
    {
        // TODO: 011 Create Factory method to be used by Gunnery class



        static void Main()
        {
            var factory = new ShootingTacticsFactory();
            var gunnery = new Gunnery(factory);
            gunnery.RecordHitResult(HitResult.Hit);
        }
    }
}
