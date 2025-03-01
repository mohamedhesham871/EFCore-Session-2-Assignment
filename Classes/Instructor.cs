using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_2_Assignment.Classes
{
    internal class Instructor
    {
        //USing Convol...
        public int ID { get; set; }
        public required string Name { get; set; }
        public required decimal Salary { get; set; }
        public decimal? Bouns { get; set; }
        public string? Address { get; set; }
        public int HourRate { get; set; }
        public int  Dept_ID { get; set; }
    }
}
