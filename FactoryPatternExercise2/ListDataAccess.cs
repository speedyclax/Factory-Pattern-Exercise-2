using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "Drums", Price = 900},
            new Product(){ Name = "Guitar", Price = 1200},
            new Product(){ Name = "Bass", Price = 1000},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a list database");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data from a list database");
        }
    }
}
