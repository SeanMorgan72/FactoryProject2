﻿using System;
namespace FactoryProject2
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
