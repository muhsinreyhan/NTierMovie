using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NTierMovie.DAL.Model.Entity;

namespace NTierMovie.DAL.Model.Context
{
    public class MovieContex : DbContext
    {
        public MovieContex()
        {
            Database.Connection.ConnectionString = "server=.;database=NTierMovieMDb;uid=sa;pwd=123";
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
