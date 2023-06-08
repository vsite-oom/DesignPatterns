namespace DesigPatterns.LazyInitialization
{
    class Car
    {
        public Car(string model)
        {
            Model = model;
        }

        public readonly string Model;
    }

    class CarDealer
    {
        private readonly Dictionary<string, Car> availableCars = new Dictionary<string, Car>();

        public Car GetCar(string model)
        {
            // TODO: 1.5 Implement method so that objects are created on demand.

            return null;
        }
    }

    static internal class Program
    {
        static string SameInstances(Car car1, Car car2)
        {
            return $"Models {car1.Model} and {car2.Model} are {(ReferenceEquals(car1, car2) ? string.Empty : "NOT")} same instances";
        }

        static void Main()
        {
            var dealer = new CarDealer();
            var tesla1 = dealer.GetCar("Tesla model S");
            var mercedes = dealer.GetCar("Mercedes SE 200");
            Console.WriteLine(SameInstances(tesla1, mercedes));

            var tesla2 = dealer.GetCar("Tesla model S");
            Console.WriteLine(ReferenceEquals(tesla1, tesla2));
            Console.WriteLine(SameInstances(tesla1, tesla2));
        }
    }
}
