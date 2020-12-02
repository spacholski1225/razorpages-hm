using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPages.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }
        public DbSet<Student> Student
        {
            get; set;
        }
    }
}
