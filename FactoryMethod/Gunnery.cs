using System.Diagnostics;

namespace DesignPatterns.FactoryMethod
{
    public enum HitResult
    {
        Missed,
        Hit,
        Sunk
    }

    public enum CurrentShootingTactics
    {
        Random,
        Zone,
        Line
    }

    public class Square
    { }


    public class Gunnery
    {
        public Gunnery(ShootingTacticsFactory factory) 
        {
            this.factory = factory;
        
        }
        private readonly ShootingTacticsFactory factory;

        public Square NextTarget()
        {
            return shootingTactics.NextTarget();
        }

        public void RecordHitResult(HitResult hitResult)
        {
            switch (hitResult)
            {
                case HitResult.Missed:
                    return;
                case HitResult.Sunk:
                    shootingTactics = factory.Create(CurrentShootingTactics.Random); 
                    CurrentShootingTactics = CurrentShootingTactics.Random;
                    return;
                case HitResult.Hit:
                    switch (CurrentShootingTactics)
                    {
                        case CurrentShootingTactics.Random:
                            shootingTactics = factory.Create(CurrentShootingTactics.Zone);
                            CurrentShootingTactics = CurrentShootingTactics.Zone;
                            return;
                        case CurrentShootingTactics.Zone:
                            shootingTactics = factory.Create(CurrentShootingTactics.Line);
                            CurrentShootingTactics = CurrentShootingTactics.Line;
                            return;
                        case CurrentShootingTactics.Line:
                            return;
                        default:
                            Debug.Assert(false, "Unsupported shooting tactics");
                            break;
                    }
                    break;
                default:
                    Debug.Assert(false, "Unsupported hit result");
                    break;
            }
        }

        private IShootingTactics shootingTactics;

        public CurrentShootingTactics CurrentShootingTactics { get; private set; }
    }
}
