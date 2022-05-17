using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Taxi GetTaxi()
        {
            Taxi taxi = null;
            if (taxis.Count == 0)
            {
                taxi = new Taxi();
            }
            else
            {
                taxi = taxis.Dequeue();
            }
            Console.WriteLine($"Taxi No. {taxi.CarNo} taken");
            return taxi;
        }

        public void ReleaseTaxi(Taxi taxi)
        {
            Console.WriteLine($"Taxi No. {taxi.CarNo} released");
            taxis.Enqueue(taxi);
        }

        private readonly Queue<Taxi> taxis = new Queue<Taxi>();
    }

    class Program
    {
        static void Main(string[] args)
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
