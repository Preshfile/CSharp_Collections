using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenge_GenericCollections_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                create a method that will declare a dictionary with int and string key-value pairs. 
                It should contain values from 0 to 5 with its spelling in lowercase ( 1,  "one" ).
                As input, this method will get an int. 
                The integer should be tested if it exists in the structure or not. 
                And corresponding value should be returned otherwise, "nope" should be returned.
             */

            string value = MyNumberCollections(0);
            Console.WriteLine(value);

            Console.ReadKey();
        }

        public static string MyNumberCollections(int number)
        {
            Dictionary<int, string> intCollections = new Dictionary<int, string>()
            {
                {0, "zero" },
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" }
            };

            if(intCollections.ContainsKey(number))
            {
                return intCollections[number];
            }
            else
            {
                return "nope";
            }
        }
    }
}