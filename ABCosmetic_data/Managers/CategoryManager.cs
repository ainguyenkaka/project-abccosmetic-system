using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.Managers
{
    public class CategoryManager : AbstractManager<Category>
    {
       

        public CategoryManager() : base(Manager.GetDB().Categories)
        {

        }
        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }

        public override bool Update(Category item)
        {
            Category oldItem = GetByID(item.id);
           if(oldItem != null)
            {
                oldItem.name = item.name;
                oldItem.image = item.image;
            }
            return SaveChanges();
        }

    }
}