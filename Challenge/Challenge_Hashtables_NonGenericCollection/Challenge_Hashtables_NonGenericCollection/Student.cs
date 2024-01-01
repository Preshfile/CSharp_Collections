// Ignore Spelling: Hashtables

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Hashtables_NonGenericCollection
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gPA)
        {
            Id = id;
            Name = name;
            GPA = gPA;

        }
    }
}
