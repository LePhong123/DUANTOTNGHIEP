using DaTa.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTa.IRepositories.Repositories
{
    internal class AllRepositories<T> : IAllRepositories<T> where T : class
    {
        private readonly CHGiayDBContext context;
        private readonly DbSet<T> dbset;
        public AllRepositories()
        {
            
        }
        public AllRepositories(CHGiayDBContext context,DbSet<T> dbset)
        {
            this.context = context;
            this.dbset = dbset;
        }
        public bool Add(T item)
        {
            try
            {
                dbset.Add(item);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T item)
        {
            try
            {
                dbset.Add(item);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<T> GetAll()
        {
            return dbset.ToList();
        }

        public bool Update(T item)
        {
            try
            {
                dbset.Update(item);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
