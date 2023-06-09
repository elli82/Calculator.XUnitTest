using Calculator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.Data
{
    public class Context : DbContext
    {
        public Context() { }   
        
        public Context( DbContextOptions<Context>options) :base (options) 
        {
        }

        public DbSet<Result> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-5M0EIGI;Database=CalculatorDb;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
