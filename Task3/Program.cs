using System;

namespace Singleton
{
    public sealed class DatabaseRepository
    {
        private static volatile DatabaseRepository instance;
        private static readonly object syncRoot = new Object();

        private DatabaseRepository() { }

        public static DatabaseRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DatabaseRepository();
                        }
                    }
                }

                return instance;
            }
        }

        public void Query(string query)
        {
            Console.WriteLine($"Querying the database with: {query}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DatabaseRepository database = DatabaseRepository.Instance;
            database.Query("SELECT * FROM Customers");

            Console.ReadLine();
        }
    }
}
