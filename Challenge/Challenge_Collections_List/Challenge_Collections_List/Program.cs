namespace Challenge_Collections_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a method that returns a list of even integer numbers 
             between 100 and 170 (inclusive).
            */

            List<int> numberCollection = new List<int>();

            //populate the list with numbers from 100 to 170
            for(int i = 100; i <= 170; i++)
            {
                numberCollection.Add(i);
            }

            EvenNumbersCollection(numberCollection);

            Console.WriteLine("\n");


            //second method
            List<int> result = EvenNumberCollection();

            foreach(int number in result)
            {
                Console.Write($" {number}");
            }


            Console.ReadKey();
        }

        public static List<int> EvenNumbersCollection(List<int> numbers)
        {
            //create an instance of the class list
            List<int> evenNumbers = new List<int>();

            //add each element to the list
            foreach(int number in numbers)
            {
                evenNumbers.Add(number);
            }

            //print each even number in the list
            foreach(int evenNumber in evenNumbers)
            {
                if (evenNumber % 2 == 0)
                {
                    Console.Write($" {evenNumber}");
                }
            }
            return evenNumbers;
        }


        //Another way with no argument
        public static List<int> EvenNumberCollection()
        {
            List<int> EvenNumbers = new List<int>();

            for(int i = 100; i <= 170; i++)
            {

                if(i % 2 == 0)
                {
                    EvenNumbers.Add(i);
                }
            }

            return EvenNumbers;
        }
    }
}