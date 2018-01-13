using ABCosmetic_data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ABCosmetic_data.Entities;

namespace ABCosmetic_data.Managers
{
    public class Manager
    {
 
        public static readonly Manager instance = new Manager();
        private static ABCContext db;
       
        private Manager()
        {
            db = new ABCContext();
    
        }

        public static Manager GetInstance()
        {
            return instance;
        }

        public static ABCContext GetDB()
        {
            return db;
        }

        public static bool SaveChanges()
        {
            try
            {
                return db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

      
      
    }
}