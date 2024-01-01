using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections_Dictionaries
{
    internal class Employee
    {
        //properties
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary 
        {   
            //Yearly salary = Rate * hour * number of days * number of weeks * number 
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        
        }

        public Employee(string role, string name, int age, float rate)
        {
            Role = role;
            Name = name;
            Age = age;
            Rate = rate;
        }

    }
}
