using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_2_Assignment.Classes
{
    internal class Student
    {
        public int Id { get; set; }
        public required string FName { get; set; } 
        public required string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dept_ID { get; set; }
    }
}
