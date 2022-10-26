using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Student
    {
        public Student(string firstName, string lastName, int age, string group)
        {
            id = Guid.NewGuid();
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.group = group;
        }
        public Guid id { get; }
        public string firstName { get; }
        public string lastName { get; }
        public int age { get; }
        public string group { get; }
    }
}
