namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please select your database from the following options: List, SQL, Mongo");
            var userInput = Console.ReadLine();

            IDataAccess database = DataAccessFactory.GetDataAccessType(userInput);

            var products = database.LoadData();
            
            Console.WriteLine("");

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
            Console.WriteLine("");

            database.SaveData();
        }
    }
}
