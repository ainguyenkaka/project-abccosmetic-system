using ABCosmetic_app.ProductService;
using ABCosmetic_app.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCosmetic_app.Models
{
    public class CustomersProducts
    {
        public List<User> customers { get; set; }
        public List<Product> products { get; set; }
    }
}