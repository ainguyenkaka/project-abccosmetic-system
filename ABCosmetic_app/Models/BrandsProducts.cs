using ABCosmetic_app.BrandService;
using ABCosmetic_app.CategoryService;
using ABCosmetic_app.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCosmetic_app.Models
{
    public class BrandsProducts
    {
        public List<Product> products { get; set; }
        public List<Brand> brands { get; set; }
    }
}

