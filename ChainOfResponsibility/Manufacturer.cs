using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    internal class Manufacturer : ProductSupplier
    {
       
        public override Product GetProduct()
        {
            if (productsInWarehouse.Count > 0)
            {
                var product = productsInWarehouse[0];
                productsInWarehouse.RemoveAt(0);
                return product;
            }
            return null;
        }

        private readonly List<Product> productsInWarehouse = new List<Product>();
          
    }
}
