using ABCosmetic_app.Models.Managers;
using ABCosmetic_app.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABCosmetic_app.Filters
{
    public class ManagerAuth : AuthorizeAttribute, IAuthorizationFilter
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {

            User user = HttpContext.Current.Session["user"] as User;
            bool isManager = false;
            if(user != null)
            {
                isManager = ServiceManager.getInstance().IsManager(user.email);
            }
            if (!isManager)
                base.HandleUnauthorizedRequest(filterContext);
        }
    }
}