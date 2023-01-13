using GameLibrary.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.DAL.Database.Contexts
{
    public class GamesDbContext: DbContext
    {
        public GamesDbContext(DbContextOptions <GamesDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyWorker> CompanyWorkers { get; set; }
        //public virtual DbSet<Programmer> Programmers { get; set; }
        //public virtual DbSet<ArtCreator> ArtCreators { get; set; }
        //public virtual DbSet<Manager> Managers { get; set; }
//        public virtual DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set;}
    
    }
}
