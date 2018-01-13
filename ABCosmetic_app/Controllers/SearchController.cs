using ABCosmetic_app.BrandService;
using ABCosmetic_app.Filters;
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
    public class SearchController : Controller
    {
        private ServiceManager serviceManager;
        private BrandsProducts viewModel;


        public SearchController()
        {
            serviceManager = ServiceManager.getInstance();
            viewModel = serviceManager.GetViewModel();
        }

        // GET: Search
        public ActionResult Index(int index = 1)
        {
            String text = this.Request.Params.Get("text");
            BrandsProducts model = HandleQuery(text);
            ViewBag.Text = text;
            return View("Result",model);
        }

        private BrandsProducts HandleQuery(String text)
        {
            BrandsProducts model = null;
            if (!String.IsNullOrEmpty(text))
            {
                List<Product> products = serviceManager.SearchProductsByName(text);
                List<Brand> brands = viewModel.brands;
                model = new BrandsProducts { products = products, brands = brands };
            }
            else
                model = viewModel;

            return model;
        }

        public ActionResult Range(int index = 1)
        {
            try
            {
                BrandsProducts model = HandleParameters(Request.Params["cId"], Request.Params["low"], Request.Params["high"]);
                return View("Result", model);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            
        }

        private BrandsProducts HandleParameters(String incId, String inlow, String inhigh)
        {
            try
            {
                int cId = Int32.Parse(incId);
                int low = Int32.Parse(inlow);
                int high = Int32.Parse(inhigh);

                List<Product> products = null;
                if (cId == 0)
                    products = serviceManager.SearchProductsByPriceRange(low, high);
                else
                    products = serviceManager.SearchProductsByPRC(low, high, cId);

                List<Brand> brands = viewModel.brands;
                BrandsProducts model = new BrandsProducts { products = products, brands = brands };
                return model;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}