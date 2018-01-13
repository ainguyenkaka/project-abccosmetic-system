using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Managers
{
    public class StoreManager : AbstractManager<Store>
    {
      
        public StoreManager() : base(Manager.GetDB().Stores)
        {

        }

        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }

        public override bool Update(Store item)
        {
            return false;
        }

    }
}
