using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovie.DAL.Model.Entity
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            CreateDate = DateTime.Now;
            IsActive = true;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
