using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program2
    {
        static void Main(string[] args)
        {
            // 3 Instances of that customer class
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Dylan",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Kyle",
                Salary = 6500
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rav",
                Salary = 8000
            };

            // Creating of the Dictionary with a KEY of type int, and a VALUE of type Customer
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            // This is the actual adding of the Customers
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            // If not sure if the dictionary contains the key, use .TryGetValue
            Customer cust;
            if (dictionaryCustomers.TryGetValue(111, out cust))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }

            // Finds total number of items in the dictionary us .Count, or the method .Count()
            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count);
            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 6000));

            // To remove an entry in the dictionay, use Remove()
            // If you enter a number that is not currently in the dictionary, no error occurs and nothing 
            // is removed
            dictionaryCustomers.Remove(999);

            // To remove ALL entries, use .Clear();
            dictionaryCustomers.Clear();



        }
    }

    // Basic Customer class to be added to dictionary
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
