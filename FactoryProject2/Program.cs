using System;

namespace FactoryProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do yo want to use: a List, SQL, or Mongo? \n");
            Console.WriteLine("Enter list: \n");
            Console.WriteLine("Enter sql: \n");
            Console.WriteLine("Enter mongo: \n");

            var input = Console.ReadLine();

            IDataAccess dataBase = DataAccessFactory.GetDataAccessType(input);

            var products = dataBase.LoadData();

            dataBase.SaveData();

            foreach(var item in products)
            {
                Console.WriteLine($"Name: {item.Name} Price: ${item.Price}\n");
            }
        }
    }
}
