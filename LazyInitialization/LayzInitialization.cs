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
            
            // TODO: 016 Implement method so that objecst are created on demand.
            if (availableCars.TryGetValue(model, out Car car))
            {
                return car;
            }
            car = new Car(model);
            availableCars.Add(model, car);
            return car;
        }
    }

    static internal class Program
    {
        static void Main()
        {
            var dealer = new CarDealer();
            var tesla1 = dealer.GetCar("Tesla model S");
            var mercedes = dealer.GetCar("Mercedes SE 200");
            Console.WriteLine(ReferenceEquals(tesla1, mercedes));

            var tesla2 = dealer.GetCar("Tesla model S");
            Console.WriteLine(ReferenceEquals(tesla1, tesla2));
        }
    }
}
