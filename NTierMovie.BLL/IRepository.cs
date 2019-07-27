using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierMovie.DAL.Model.Entity;

namespace NTierMovie.BLL
{
    interface IRepository<T> where T:EntityBase
    {
        void Insert(T item);
        void Delete(int ItemId);
        void Update(T item);
        List<T> SelectAll();
        T SelectById(int itemId);
    }
}
