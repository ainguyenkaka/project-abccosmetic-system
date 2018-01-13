using ABCosmetic_data.DAL;
using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCosmetic_data.Managers
{
    public class BrandManager : AbstractManager<Brand>
    {
        
        public BrandManager() : base(Manager.GetDB().Brands)
        {

        }

        public override bool Update(Brand item)
        {
            return false;
        }

        public override bool SaveChanges()
        {
            return Manager.SaveChanges();
        }
    }
}
