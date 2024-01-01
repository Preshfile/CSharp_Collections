// Ignore Spelling: Hashtable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollection_Hashtable
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            //this in the constructor helps to distinguish between instance members and parameters
            //to avoid naming conflict
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
