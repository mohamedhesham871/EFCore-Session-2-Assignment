using EFCore_Session_2_Assignment.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_2_Assignment.Config
{
    internal class Course_Instructor_Configration : IEntityTypeConfiguration<course_Insructor>
    {
        public void Configure(EntityTypeBuilder<course_Insructor> builder)
        {
            builder.HasKey(e=>new {e.CourseID,e.insructorID});

            builder.Property(r => r.evaluate).IsRequired();
        }
    }
}
