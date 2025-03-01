using EFCore_Session_2_Assignment.Classes;
using EFCore_Session_2_Assignment.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session_2_Assignment
{
    internal class ITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Mohamed-Hesham\\MSSQLSERVER01 ; Database= MYITI; Integrated Security =True ;TrustServerCertificate =True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasKey(d => d.ID);

            modelBuilder.Entity<Department>().Property<string>("Name").
                                                HasMaxLength(50).
                                                IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Department>().Property<DateTime>("Hiring_Date").HasColumnType("date");



            modelBuilder.Entity<Student_Course>().HasKey(e => new {e.StudentID, e.CourseID});

            modelBuilder.Entity<Student_Course>().Property("Grade").
                                                  HasColumnType("int").
                                                  IsRequired().
                                                  HasDefaultValue(10);

            //USing configuration

            //modelBuilder.ApplyConfiguration(new TopicConfigration());
            //modelBuilder.ApplyConfiguration(new Course_Instructor_Configration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        public DbSet<Student> students { get; set; } 
        public DbSet<Course> courses { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Department> departments { get; set; }  


        
    }
}
