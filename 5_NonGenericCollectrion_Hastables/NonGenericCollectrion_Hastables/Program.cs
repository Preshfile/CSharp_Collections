// Ignore Spelling: Hastables

using NonGenericCollection_Hashtable;
using System.Collections;

namespace NonGenericCollection_Hastables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtables are of the type non-Generic collections and can store different types

            //Creating and initializing a hashtable
            Hashtable studentsTable = new Hashtable();

            //store data in a Hashtable
            Student student1 = new Student(1, "Onyedika", 70);
            Student student2 = new Student(2, "Amara", 90);
            Student student3 = new Student(3, "Victor", 76);
            Student student4 = new Student(4, "Wendy", 50);

            studentsTable.Add(student1.Id, student1 );
            studentsTable.Add(student2.Id, student2 );
            studentsTable.Add(student3.Id, student3 );
            studentsTable.Add(student4.Id, student4 );

            //retrieve individial item from a Hashtable with known ID
            //To retrieve any particular student object, it needs to be cast to type Student
            
            //Student retrieveStudent = (Student)studentsTable[1];

            //or
            Student storedStudent1 = (Student)studentsTable[student1.Id];

            //Console.WriteLine("Student1 ID: {0}\nStudent1 name: {1}\nStudent1 GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);


            //Assuming we want to print all the data in our Hashtable and we have no ket at our disposal
            //We can solve this problem by getting all the keys from our Hashtable with a struct called Dictionary entry.
            //retrieve all values from a Hashtable

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student student = (Student)entry.Value;

                Console.WriteLine("Student ID: {0}", student.Id);
                Console.WriteLine("Student name: {0}", student.Name);
                Console.WriteLine("Student GPA: {0}\n", student.GPA);
            }

            //OR - Another way:
            Console.WriteLine("\n*************  OR  *************\n");

            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", student.Id);
                Console.WriteLine("Student name: {0}", student.Name);
                Console.WriteLine("Student GPA: {0}\n", student.GPA);
            }
        }
    }
}