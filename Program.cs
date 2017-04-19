using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
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

            // Since the Key of the Dictionary is also the ID, you can search your Dictionary using '[]' 
                // and whatever your key is to retrieve the instance of that customer
            Customer customer103 = dictionaryCustomers[103];

            // Simple iteration of the Dictionary to see its contents
            foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("----------------------------------------------------------");
            }
            // Directly below this comment is an example of bad code that works, but is less human readable

            // foreach(var customerKeyValuePair in dictionaryCustomers)

            // The VAR keyword does not allow a person reading your code to know what the key and value 
                // datatypes are and again, make it harder to read.

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
