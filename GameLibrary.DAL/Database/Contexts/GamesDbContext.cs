using GameLibrary.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.DAL.Database.Contexts
{
    public class GamesDbContext: DbContext
    {
        public GamesDbContext(DbContextOptions <GamesDbContext> options) : base(options)
        {

        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
