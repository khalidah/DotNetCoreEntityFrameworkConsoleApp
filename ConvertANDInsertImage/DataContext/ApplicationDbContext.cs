using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConvertANDInsertImage.Model;


namespace ConvertANDInsertImage.DataContext
{
    class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server= ;initial catalog=DB;User Id=sql;Password=Gr;TrustServerCertificate=True");
             
        }
        public DbSet<StudentClass> Studentobj { get; set; }
        public DbSet<EmployeeClass> Employee { get; set; }


    }
}
