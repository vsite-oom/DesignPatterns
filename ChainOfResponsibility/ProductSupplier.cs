namespace DesignPatterns.ChainOfResponsibility
{
    internal abstract class ProductSupplier
    {
        public abstract Product? GetProduct();

        public void SetNextHandler(ProductSupplier provider)
        {
            nextHandler = provider;
        }

        protected ProductSupplier? nextHandler;
    }
}
