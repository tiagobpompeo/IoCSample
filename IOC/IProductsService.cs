using System;
using System.Collections.Generic;

namespace IOC
{
    public interface IProductsService
    {

        IEnumerable<Product> Getproducts();
    }
}
