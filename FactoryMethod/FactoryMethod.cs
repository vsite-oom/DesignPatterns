namespace DesignPatterns.FactoryMethod
{
    static class ShootingTacticFactory
    {
        public static IShootingTactics CreateShootingTactics(CurrentShootingTactics shootingTactics)
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
                    throw new ArgumentException();
            }
        }
    }
    static internal class Program
    {
        // TODO: 1.0 Create Factory method to be used by Gunnery class.

        static void Main()
        {
            var gunnery = new Gunnery();
            gunnery.RecordHitResult(HitResult.Hit);
        }
    }
}
