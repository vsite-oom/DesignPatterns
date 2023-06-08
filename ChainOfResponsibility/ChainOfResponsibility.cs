namespace DesignPatterns.ChainOfResponsibility
{
    internal class Program
    {
        // TODO: 039 Implement Manufacturer class and append it into the chain of responsibilities.
        private static void Main(string[] args)
        {
            var store = new Store();
            var warehouse = new Warehouse();

            store.SetNextHandler(warehouse);


            var product = store.GetProduct();
            if (product == null)
            {
                Console.WriteLine("Product is discontinued");
            }
            else
            {
                Console.WriteLine("Product is available");
            }
        }
    }
}
