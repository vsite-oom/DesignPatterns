namespace DesignPatterns.FactoryMethod
{

    public class shootingTacticsFactory
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
                default: return null;



            }
        }
    }
    public class Program
    {
        
        // TODO: 011 Create Factory method to be used by Gunnery class
       
        static void Main()
        {
            
            var gunnery = new Gunnery(new shootingTacticsFactory());
            gunnery.RecordHitResult(HitResult.Hit);
        }
    }
}
