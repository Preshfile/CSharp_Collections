// Ignore Spelling: Hashtables

using System.Collections;

namespace Challenge_Hashtables_NonGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Write a program that will iterate through each element of the student array
               and insert them into a hashtable.
               If a student with the same ID already exist in the hashtable, skip it and 
               Display the following error: "Sorry, a student with the same id already exists."

               Hint: Use the method CotainsKey() to check whether a student with the same ID already exist.
            */
            //create an instance of the class
            Student[] students = new Student[5];

            //populate the array
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 58);
            students[2] = new Student(6, "Ifeoma", 78);
            students[3] = new Student(1, "Luise", 90);
            students[4] = new Student(4, "Levis", 77);

            //Create an empty Hashtable

            Hashtable studentTables = new Hashtable();

            //Iterate every element in the student array
            foreach(var student in students)
            {
                if (!studentTables.ContainsKey(student.Id))
                {
                    //Add items to the hashtable if same Ids don't exist
                    studentTables.Add(student.Id, student);
                    Console.WriteLine("Student with ID: {0} was added.", student.Id);
                }
                else
                {
                    Console.WriteLine("Sorry, a student with the same id already exists ID: {0}.", student.Id);
                    //You can write a code that assigns a different Id to a student if same Id exist
                }
            }

        }
    }
}