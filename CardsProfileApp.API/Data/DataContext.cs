using CardsProfileApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CardsProfileApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {}
        
        public DbSet<ProfileCard> ProfileCards { get; set; }
        public DbSet<User> Users { get; set; }
    }
}