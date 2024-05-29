namespace DesignPatterns.FactoryMethod
{
    class ShootingTacticsFactory
    {
        public static IShootingTactics CreateShootingTactics(CurrentShootingTactics shootingTactics)
        {
            switch (shootingTactics)
            {
                case CurrentShootingTactics.Random:
                    return new ZoneShooting();
                case CurrentShootingTactics.Zone:
                    return new ZoneShooting();
                case CurrentShootingTactics.Line:
                    return new ZoneShooting();
                default:
                    throw new ArgumentException();
            }
        }
    }
    static internal class Program
    {
        //  1.0 Create Factory method to be used by Gunnery class.

        static void Main()
        {
            var gunnery = new Gunnery();
            gunnery.RecordHitResult(HitResult.Hit);
        }
    }
}
