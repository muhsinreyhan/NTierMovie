using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovie.DAL.Model.Entity
{
    public class Film:EntityBase
    {
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public int ActorId { get; set; }
        public int GenreId { get; set; }


        //Mapping
        //LazyLoad

        public virtual List<Actor> Actors { get; set; }
        public virtual Director Directors { get; set; }
        public virtual Genre Genres { get; set; }
    }
}
