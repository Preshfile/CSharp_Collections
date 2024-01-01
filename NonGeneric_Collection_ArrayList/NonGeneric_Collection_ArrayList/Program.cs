using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
namespace NonGeneric_Collection_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring an ArrayList
            ArrayList collection1 = new ArrayList(); //this stores indefinite amount of objects

            //declaring an ArrayList with the size
            ArrayList collection2 = new ArrayList(150); //this stores a definite number of only 150 objects

            //ArrayList Methods

            //Add() - Adds an object to the end of the ArrayList.
            collection1.Add(300);
            collection1.Add("Simi");
            collection1.Add(300.00);
            collection1.Add('C');
            collection1.Add("Sandra");
            collection1.Add(34);
            collection1.Add(222);
            collection1.Add(160);
            collection1.Add("Stefanie");
            collection1.Add(34.8);
            collection1.Add(34.8);


            // Remove() - Removes the first occurrence of a specific object from the ArrayList.
            collection1.Remove(34);

            //RemoveAt() - Removes the element at the specified index in the ArrayList.
            collection1.RemoveAt(8);

            //Clear() - Removes all elements from the ArrayList.
            //collection1.Clear();

            //Contains() - Determines whether the ArrayList contains a specific element.
            bool contain = collection1.Contains(220);
            Console.WriteLine(contain);

            //IndexOf() - Returns the index of the first occurrence of a specific object in the ArrayList.
            float myIndex = collection1.IndexOf(34.8);
            Console.WriteLine(myIndex);

            //count - is a ReadOnly property. It Gets the number of elements actually contained in the ArrayList.
            int countElements = collection1.Count;
            Console.WriteLine($"{countElements}\n");

            //Insert() - Inserts an element into the ArrayList at the specified index.
            collection1.Insert(4, "Ugo");

            foreach (var item in collection1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


            //Calculate all the numbers in the array list
            double sum = 0;
            foreach(object myNumber in collection1)
            { //used object as a data type because that is the highest class every other data type inherits from
                if (myNumber is int)
                {
                    sum += Convert.ToDouble(myNumber);
                }
                else if (myNumber is double)
                {
                    sum += (double)myNumber;
                }else if (myNumber is string)
                {
                    Console.WriteLine(myNumber);
                }
            }
            Console.WriteLine(sum);

            Console.WriteLine();

            //Sort() - The Sort method is used to sort the elements in a collection in ascending order. 
            //However, since ArrayList can contain elements of different types, the Sort method may throw an exception if the elements are not mutually comparable.
            //lets create an ArrayList with same elements for this

            ArrayList myNumberCollections = new ArrayList();

            myNumberCollections.Add(40);
            myNumberCollections.Add(10);
            myNumberCollections.Add(57);
            myNumberCollections.Add(49);
            myNumberCollections.Add(80);
            myNumberCollections.Add(30);
            myNumberCollections.Add(22);

            myNumberCollections.Sort();

            foreach (var number in myNumberCollections)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            //ToArray() - is a method that makes a copy of the ArrayList on which it is called
            object[] newNumberCollections = myNumberCollections.ToArray();

            foreach (var num in newNumberCollections)
            {
                Console.WriteLine(num);
            }


            Console.ReadKey();
        }
    }
}