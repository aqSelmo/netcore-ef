using Microsoft.EntityFrameworkCore;
using MangasLobby.Models;

namespace MangasLobby.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Image> Image { get; set; }
    }
}