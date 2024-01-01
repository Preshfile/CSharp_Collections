namespace Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*we have used methods that use params already. i.e WriteLine()
             - when you hover over WriteLine, you can see it has multiple overloads
             - WriteLine method has about 18 different overloads
             - overloads are the different kinds of implementations for this method
             - meaning there are multiple implementations for the WriteLine() Method
             - it accepts any type of parameter though its type string
            */

            Console.WriteLine("Nelly is {0}ft tall at {1}", 6, 22); //accepts all param
            Console.WriteLine("Calculate: {0} + {1} + {2} + {3} + {4} + {5} + {6} = {7}", 1, 2, 3, 4, 5, 6, 7, 1+2+3+4+5+6+7 ); //It accepts all kinds of params or input

            //The param keyword allows us to pass as many parameters as we want 
            //We can as well pass no parameter and nothing happens and our code doesn't crash either
            
            ParamsMethod("Routine " + "coding " + "is " + "such " + "an " + "exciting " + "and " + "rewarding " + "habit ");

            string name = "Dan";
            char sign = '@';
            int age = 27;
            
            ParamsMethod2(name, sign, age);

            //Here we are passing values directly
            ParamsMethod2("Ayo", '%', 100 );


            //Method that sums endless number of arguments
            Console.WriteLine(SumInt(2, 3, 4, 5));
            Console.WriteLine(SumInt(10, 20, 30, 40, 50));
            Console.WriteLine(SumInt(8, 11, 19));
            Console.WriteLine(SumInt(200, 300, 400, 500));


            //check minimum number
            //this is very useful when you get a bunch of data from database
            //or combined data from different sources
            //then compare them to get a minimum number
            int minimumNumber1 = checkMinNumber(20, 50, 70, 10, 9, 11, 5000, 200); 
            Console.WriteLine("The minimum number is: {0}", minimumNumber1);

            int minimumNumber2 = checkMinNumber (50, 70, 10, 9, 11, -5000, 200);
            Console.WriteLine("The minimum number is: {0}", minimumNumber2);


            Console.ReadKey();
        }
        //method that allows parameters
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        //methods that allow objects
        public static void ParamsMethod2(params object[] stuff)
        {
            //loop through the array of objects
            foreach (object obj in stuff)
            {
                //print each object, add space
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }

        /*Every single class has an internally a method called to string
         - This means whatever object you give to the method, it will be able to make a string out of it
         - and the program will not crash.
        */


        /*Why use the param keyword?
         - Param allows a method to accept variable number of arguments
         - This means you can pass in as many arguments as you want or none at all
         - The params keyword allows us to create flexible methods easily
         - so flexibility is one major advantage of this keyword - you can pass in any number of arg
         - It makes the method much more versatile

                 HOWEVER...(Limitations of params methods
         - One major disadvantage is that it can only be used with the last parameter of a method
         - if every method is variabled, it can be confusing to read
         - Using params can impact performance.
         */

        //Create a method that calculates the sum of unknown number of integers
        public static int SumInt(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public static int checkMinNumber(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach(int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
            }
           return min;
        }

        //in summary, params is a great tool for creating a method that takes in any number of parameters
    }
}