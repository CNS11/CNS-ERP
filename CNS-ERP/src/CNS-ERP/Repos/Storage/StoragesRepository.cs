using CNS_ERP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNSS_ERP.DAL.Models.Storage;
using CNSS_ERP.DAL;
using Microsoft.EntityFrameworkCore;

namespace CNS_ERP.Repos.Storage
{
    public class StoragesRepository : IRepository<Storages>
    {
        private readonly CNSS_ERP.DAL.ApplicationDbContext _context =new CNSS_ERP.DAL.ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<CNSS_ERP.DAL.ApplicationDbContext>());
        public StoragesRepository()
        {
            this._context = new CNSS_ERP.DAL.ApplicationDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<CNSS_ERP.DAL.ApplicationDbContext>());
        }
        public StoragesRepository(ApplicationDbContext db)
        {
            this._context = db;
        }
        public bool Delete(int id)
        {
            try
            {
                lock (_context)
                _context.StoragesDbSet.Remove(_context.StoragesDbSet.Where(x => x.StorageId == id).First());
                _context.SaveChanges();

            }
            catch (DbUpdateException)
            {

                return false;
            }
            return true;

        }

        public bool Exists(int id)
        {
           return this._context.StoragesDbSet.Any<Storages>(x => x.StorageId == id);
        }

        public bool Insert(Storages obj)
        {
            try
            {
                lock (_context)
                this._context.StoragesDbSet.Add(obj);
            }
            catch (Exception)
            {

                return false;
            }


            Save();
            return true;
            
        }

        public bool Save()
        {
            try
            {
                this._context.SaveChangesAsync();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
            

        }

        public IEnumerable<Storages> SelectAll()
        {
            lock (_context)
                return this._context.StoragesDbSet.ToList<Storages>();
        }

        public Storages SelectByID(int id)
        {
            return _context.StoragesDbSet.Where(x => x.StorageId == id).First();
        }

        public bool Update(Storages obj)
        {
            _context.Entry<Storages>(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
            return true;
        }
    }
}
