namespace DesignPatterns.ChainOfResponsibility
{
    internal class Store : ProductSupplier
    {
        public override Product GetProduct()
        {
            if (productsOnShelf.Count > 0)
            {
                var product = productsOnShelf[0];
                productsOnShelf.RemoveAt(0);
                return product;
            }
            return nextHandler.GetProduct();
        }

        private readonly List<Product> productsOnShelf = new List<Product>();
    }
}
