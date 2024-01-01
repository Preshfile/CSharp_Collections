using System;
using System.Collections;

namespace Generic_And_NonGeneric_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * What are collections
             * - Collections are classes that we can use to store a collection of objects
             * - unlike arrays, collections are not limited to one type of object - we can store as many as we want.
             * - unlike arrays, collections are not fixed in size, it adjusts its size as we add more elements
             * 
             * Why do we need collections?
             * - To efficiently store, manage, and manipulate a group of objects
             * - Collections can be used with methods to perform different operations like:
             *    - adding objects,
             *    - deleting objects,
             *    - replacing objects,
             *    - searching objects,
             *    - copying objects
             * 
             * Types of Collections
             * There are two types of collections:
             * 1) Generic Collections - stores only one type of object
             *    - Location: System.Collections.Generic namespace
             * 
             * 2) Non-Generic Collections - can store any type of object - different object types
             *    - Location: System.Collections namespace
             */

            // Examples of Non-Generic Collection

            int number = 30;
            string name = "Uche";
            char grade = 'A';
            double amount = 300000;

            ArrayList myCollection = new ArrayList();

            myCollection.Add(number);
            myCollection.Add(name);
            myCollection.Add(grade);
            myCollection.Add(amount);

            // Iterate through the collection and print each item
            foreach (var item in myCollection) //var allows the compiler determine the type of the item.
            {
                Console.WriteLine(item);
            }

            // Alternative way of printing each item
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Amount: {amount}");


            // Examples of Non-Generic Collection
            string firstPerson = "Alicia";
            string secondPerson = "Mary";
            string thirdPerson = "Hanna";
            string fourthPerson = "Amanda";

            List<string> myList = new List<string>();

            myList.Add(firstPerson);
            myList.Add(secondPerson);
            myList.Add(thirdPerson);
            myList.Add(fourthPerson);

            foreach (var item in myList)
            {
                Console.WriteLine($"\n {item}");
               
            }
        }
    }
}
