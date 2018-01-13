using ABCosmetic_data.Entities;
using ABCosmetic_data.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ABCosmetic_service.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public abstract class AbstractService<T> : System.Web.Services.WebService where T : AbstractEntity
    {
        protected AbstractManager<T> manager;

        public AbstractService(AbstractManager<T> manager)
        {
            this.manager = manager;
        }

        [WebMethod]
        public String HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<T> All()
        {
            return manager.All();
        }

        [WebMethod]
        public T GetByID(int id)
        {
            return manager.GetByID(id);
        }

        [WebMethod]
        public List<T> SearchByName(string text)
        {
            return manager.searchByName(text);
        }

        [WebMethod]
        public bool Delete(int id)
        {
            return manager.Delete(id);
        }

        public T AddNew(T item)
        {
            return manager.AddNew(item);
        }

    }
}