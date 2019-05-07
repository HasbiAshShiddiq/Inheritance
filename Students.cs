using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Students : Person
    {
        public string StudentsId { get; set; }
        public string Email { get; set; }

        public Students(string name, int age, string studentsId,
            string email) : base (name, age)
        {
            Name = name;
            Age = age;
            StudentsId = studentsId;
            Email = email;
        }
    }
}
