using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovie.DAL.Model.Entity
{
    public class Genre:EntityBase
    {
        public string Description { get; set; }
        public virtual List<Film> Films { get; set; }
    }
}
