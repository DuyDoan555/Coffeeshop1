﻿using CoffeeshopTH.Models;
using System.Collections.Generic;

namespace coffeeshop.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product? GetProductDetail(int id);
    }
}
