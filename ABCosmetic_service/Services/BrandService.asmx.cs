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
    /// Summary description for BrandService
    /// </summary>
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BrandService : AbstractService<Brand>
    {
        public BrandService() : base(new BrandManager())
        {
        }

       
    }
}
