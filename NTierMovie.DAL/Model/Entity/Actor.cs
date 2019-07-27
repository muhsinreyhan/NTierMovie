using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovie.DAL.Model.Entity
{
    public class Actor:EntityBase
    {
        public string LastName { get; set; }

        public virtual List<Film> Films { get; set; }
    }
}
