namespace DesignPatterns.ObjectPool
{
    class Taxi
    {
        static int carNumber = 0;

        public Taxi()
        {
            CarNo = ++carNumber;
        }

        public readonly int CarNo;
    }

    class TaxiCarPool
    {
        // TODO: 1.6a Modify GetTaxi method so that it creates new taxi only if availableTaxis is empty, otherwise takes it from the queue.
        public Taxi GetTaxi()
        {
            //Taxi? taxi = null;
            //taxi = new Taxi();
            //Console.WriteLine($"Taxi No. {taxi.CarNo} taken");
            //return taxi;

            Taxi? taxi = null;
            if (availableTaxis.Count == 0)
            {
                taxi = new Taxi();
                Console.WriteLine($"Taxi No. {taxi.CarNo} taken");
                return taxi;
            }
            taxi = availableTaxis.Dequeue();
            Console.WriteLine($"Taxi No. {taxi.CarNo} taken");
            return taxi;
        }

        // TODO: 1.6b Modify ReleaseTaxi method so that released taxi is added to availableTaxis.
        public void ReleaseTaxi(Taxi taxi)
        {
            availableTaxis.Enqueue( taxi );
            Console.WriteLine($"Taxi No. {taxi.CarNo} released");
        }

        private readonly Queue<Taxi> availableTaxis = new Queue<Taxi>();
    }

    static internal class Program
    {
        static void Main()
        {
            TaxiCarPool pool = new TaxiCarPool();
            var taxi1 = pool.GetTaxi();
            var taxi2 = pool.GetTaxi();
            var taxi3 = pool.GetTaxi();

            pool.ReleaseTaxi(taxi3);
            pool.ReleaseTaxi(taxi1);

            var taxi4 = pool.GetTaxi();
            var taxi5 = pool.GetTaxi();

            Console.ReadKey();

        }
    }
}
