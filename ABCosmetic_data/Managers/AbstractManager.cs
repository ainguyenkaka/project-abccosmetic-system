using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.Managers
{
    public abstract class AbstractManager<T> where T : AbstractEntity
    {
        protected DbSet<T> table;
        public AbstractManager(DbSet<T> table)
        {
            this.table = table;
        }

        public abstract bool SaveChanges();

        public List<T> All()
        {
            return table.ToList<T>();
        }

        public T GetByID(int id)
        {
            return table.SingleOrDefault(item => item.id == id);
        }

        public bool IsExisted(int id)
        {
            return GetByID(id) != null;
        }

        public T AddNew(T item)
        {
            item = table.Add(item);
            SaveChanges();
            return item;
        }

        public bool Delete(int id)
        {
            T item = GetByID(id);
            if (item == null)
                return false;
            else
                item = table.Remove(item);
            return SaveChanges();
        }

        public abstract bool Update(T item);

        public List<T> searchByName(String text)
        {
            List<T> list = table.Where(item => item.name.ToLower().Contains(text.Trim().ToLower()) == true).ToList<T>();
            if (list == null)
                list = new List<T>();
            return list;
        }
    }
}