using CNSS_ERP.DAL.Models.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNS_ERP.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> SelectAll();
        Storages SelectByID(int id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(int id);

        bool Exists(int id);
        bool Save();
    }
}
