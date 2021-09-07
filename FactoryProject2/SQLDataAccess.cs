using System;
using System.Collections.Generic;

namespace FactoryProject2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
        }

        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Sony Playstation", Price = 599.00m},
            new Product() { Name = "MacBook Pro M2", Price = 1759.00m},
            new Product() { Name = "Stratcaster Guitar", Price = 3500.00m},
            new Product() {Name = "Dell XPS 15", Price = 895.00m}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a SQL Data Access.\n");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access database.\n");
        }
    }
}
