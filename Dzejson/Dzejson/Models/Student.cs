using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzejson.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MotherName { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   FirstName == student.FirstName &&
                   LastName == student.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }
    }
}
