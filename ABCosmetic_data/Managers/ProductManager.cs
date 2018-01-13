using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ABCosmetic_data.Managers
{
    public class ProductManager : AbstractManager<Product>
    {
      
     
        public ProductManager() : base( Manager.GetDB().Products)
        {
        }
        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }

        public List<Product> searchByPriceRange(decimal low, decimal high)
        {
            List<Product> list = this.table.Where(item => item.price >= low && item.price <= high).ToList();
            if (list == null)
                list = new List<Product>();
            return list;
        }

        // search products by price range and category
        public List<Product> searchByPRC(decimal low, decimal high, int cId)
        {
             List<Product> list = this.table.Where(item => item.CategoryID == cId && item.price >= low && item.price <= high).ToList();
            if (list == null)
                list = new List<Product>();
            return list;
        }

        public override bool Update(Product item)
        {
            Product oldItem = GetByID(item.id);
           if(oldItem != null)
            {
                oldItem.name = item.name;
                oldItem.price = item.price;
                oldItem.quantity = item.quantity;
                oldItem.image = item.image;
                oldItem.description = item.description;
                oldItem.CategoryID = item.CategoryID;
            }
            return SaveChanges();
        }
    }
}