namespace DesignPatterns.ChainOfResponsibility
{
    internal class Manufacturer : ProductSupplier
    {
        public override Product? GetProduct()
        {
            if (productsInProduction.Count > 0)
            {
                var product = productsInProduction[0];
                productsInProduction.RemoveAt(0);
                return product;
            }
            return null;
        }

        private readonly List<Product> productsInProduction = new List<Product>();
    }
}
