using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebAPIWithMySQL.Models
{
    public class StudentDetailContext : DbContext
    {
        public StudentDetailContext()
        {
            
        }
        public StudentDetailContext(DbContextOptions<StudentDetailContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<StudentDetail> StudentDetails { get; set; }
        //Table Name StudentDetails
    }
}