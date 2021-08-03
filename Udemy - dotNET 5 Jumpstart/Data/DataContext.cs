using Microsoft.EntityFrameworkCore;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
