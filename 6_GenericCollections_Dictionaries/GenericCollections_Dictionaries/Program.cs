
using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace GenericCollections_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Just like a Hashtable, a dictionary stores its values in key-value pairs
            //However, a dictionary stores only one specific type for both keys and values
            //a Hashtable can any objects of any types or different types as both keys and values

            //For a Dictionary, you have to specify the type for the key and value
            //Dictionary<TKey, TValue>...

            //Employees database
            Employee[] employees =
            {
                //Always recommended to use an ID as key rather than roles since more than one person can have same role
                new Employee("CEO", "Vicky", 33, 58 ),
                new Employee("MD", "Mike", 40, 40 ),
                new Employee("CGA", "Lora", 32, 38 ),
                new Employee("WYO", "Angie", 23, 20 ),
                new Employee("SSR", "Kenneth", 44, 50 ),
                new Employee("GVR", "Sandra", 50, 55 ),
                new Employee("HR", "Lora", 51, 18 ),
                new Employee("GM", "Ifeoma", 29, 38 ),
                new Employee("Intern", "Emily", 39, 48 )
            };

            //create a dictionary of store the above data
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            //loop through each data to add to the created employeesDirectory
            foreach(Employee employee in employees)
            {
                employeesDirectory.Add(employee.Role, employee);
               
            }

            //Calling data by its key

            string key = "CEO";

            if (employeesDirectory.ContainsKey(key))
            {

                Employee employee1 = employeesDirectory[key];
                Console.WriteLine("**********  Employee 1  **********\nRole: {0}\nName: {1}\nAge: {2}\nRate: {3}", employee1.Role, employee1.Name, employee1.Age, employee1.Rate);
            }
            else
            {
                Console.WriteLine("Invalid key Input! Key does not exist.");
            }


            //Using TryGetValue() - It returns true if the operation was successful otherwise, false.
            Employee result = null;

            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("\n******** Value Retrieved! ********");

                Console.WriteLine("Employee name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);

            }
            else
            {
                Console.WriteLine("The key does not exist.");
            }


            //Updating an item or entry in a dictionary

            string keyToUpdate = "HR";

            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eric", 30, 20); //replacing Lora with Eric
                Console.WriteLine("\nEmployee with role key: {0} was update.", keyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee with the key {0} was found.", key);
            }

            //Removing an item from a dictionary
            string keyToRemove = "Intern";

            if (employeesDirectory.ContainsKey(keyToRemove))
            {
                employeesDirectory.Remove(keyToRemove);
                Console.WriteLine("\nEmployee with role key: {0}, was successfully removed.", keyToRemove);
            }
            else
            {
                Console.WriteLine("No employee with the key {0} was found.", key);
            }

            //using ElementAt(i) method 
            //Linq is a very powerful tool that allows us work with collections in more efficient way.

            Console.WriteLine("\n***** Printing properties of employees *****");

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //using ElementAt(i) method to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                //print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);

                //storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;

                //Printing the properties of the employee object
          
                Console.WriteLine("Employee name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}\n", employeeValue.Salary);

            }

            Console.ReadKey();
        }
    }
}