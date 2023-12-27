using ATMManagement.MvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ATMManagement.MvcApp
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserModel> User { get; set; }
    }
}
