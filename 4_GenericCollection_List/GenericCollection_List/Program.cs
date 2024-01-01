
using System;
using System.Collections.Generic;

namespace GenericCollection_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections are classes and it requires an instance of the class to be able to add elements to the class
            //List collection of a particular type belong to the System.Collections.Generic namespace

            //one way:
           // var myListColletions = new List<int>(); //list of type int without value
           // myListColletions = new List<int> { 1, 30, 80, 70, 30 };

            //Another way:
            //create and initialize the List<int> instance in a single line
            List<int> myList = new List<int>() { 1, 30, 80, 70, 30 };

            //Adding and removing values from a list
            myList.Add(1100);
            //myList.Remove(30);
            //myList.RemoveAt(4);

            Console.WriteLine();

            //find the index of a specific element
            //the IndexOf() - doesn't directly retrieve an element at a specific index.
            //it returns the index of the element if found and -1 if not found
            //The argument passed to IndexOf is the value you're searching for, not the index.

            var getnumberAtIndex = myList.IndexOf(80);
            Console.WriteLine(getnumberAtIndex); //returns the index

            //elaborate
            if(getnumberAtIndex != -1)
            {
                int indexOfValue = myList[getnumberAtIndex];
                Console.WriteLine($"The element at index {getnumberAtIndex} is: {indexOfValue}");
            }
            else
            {
                Console.WriteLine("Value not found.");
            }

            //deletes every element in the list
            // myList.Clear();

            Console.WriteLine();

            //print all elements in the list
            foreach (int number in myList)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}