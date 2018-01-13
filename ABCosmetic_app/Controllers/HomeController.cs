using ABCosmetic_app.Models;
using ABCosmetic_app.Models.Managers;
using ABCosmetic_app.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCosmetic_app.Controllers
{
    public class HomeController : Controller
    {

        private ServiceManager serviceManager;
        private BrandsProducts viewModel;

        public HomeController()
        {
            serviceManager = ServiceManager.getInstance();
            viewModel = serviceManager.GetViewModel();
        }
        public ActionResult Index()
        {
            BrandsProducts model = viewModel;
            return View(model);
        }

        public ActionResult Shop(int index = 1)
        {

            List<Product> model = viewModel.products;
            if (model.Count <= 8)
                return View(model);
            else
            {
                int pages = model.Count / 8 + 1;
                if (index > pages || index <= 0)
                    index = 1;
                int remainder = model.Count % 8;
                if (pages != index)
                    remainder = 8;
               
                ViewBag.Pages = pages + 1;
                ViewBag.PageIndex = index;
                return View(model.GetRange((index - 1) * 8, remainder));
            }
        }


        public ActionResult Detail()
        {
            String id = this.Request.Params.Get("id");
            ViewBag.item = serviceManager.GetProduct(Int32.Parse(id));
            List<Product> model = viewModel.products;
            return View(model);
        }

      
     
    }
}