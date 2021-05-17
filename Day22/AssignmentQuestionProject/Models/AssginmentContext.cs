using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentQuestionProject.Models
{
    public class AssginmentContext :DbContext
    {
        public AssginmentContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<UserModel> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(new UserModel() { Username = "Ramu", Password = "1234" });
        }
    }
}
