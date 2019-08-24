using Microsoft.EntityFrameworkCore;
using Project.Controllers;
using Project.Data.Models;
using User = Project.Data.Models.User;

namespace Project.Data
{
    public class dbContextSchool : DbContext
    {
        public dbContextSchool(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelb)
        {
            new User.Map(modelb.Entity<User>().ToTable("User", "User"));
            base.OnModelCreating(modelb);
        }
    }
}