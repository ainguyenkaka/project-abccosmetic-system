using ABCosmetic_data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ABCosmetic_data.Managers;

namespace ABCosmetic_service.Services
{
    /// <summary>
    /// Summary description for ProductService
    /// </summary>

    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : AbstractService<Product>
    {
        public ProductService() : base(new ProductManager())
        {
        }

        [WebMethod]
        public List<Product> SearchProductsByPriceRange(decimal low, decimal high)
        {
            ProductManager pm = manager as ProductManager;
            return pm.searchByPriceRange(low, high);
        }

        [WebMethod]
        public List<Product> SearchProductsByPRC(decimal low, decimal high, int cId)
        {
            ProductManager pm = manager as ProductManager;
            return pm.searchByPRC(low, high, cId);
        }

    }
}
