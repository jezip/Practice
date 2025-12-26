using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL.Repo
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Delete(int id);
    }
}
