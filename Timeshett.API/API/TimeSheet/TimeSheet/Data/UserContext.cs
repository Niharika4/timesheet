using Microsoft.EntityFrameworkCore;
using TimeSheet.Models;

namespace TimeSheet.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
