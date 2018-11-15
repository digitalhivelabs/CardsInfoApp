using CardsProfileApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CardsProfileApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {}
        
        //public DbSet<ProfileCard> ProfileCards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        //PS Data.
        public DbSet<PSProfile> PSProfiles { get; set;}

        //Centerforlds

        //Actress

    }
}