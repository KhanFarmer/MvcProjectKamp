using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjectKamp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Admin p)
        {
            Context context = new Context();
            var AdminUserInfo = context.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);
            if (AdminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(AdminUserInfo.AdminUserName, false);

                Session["AdminUserName"] = AdminUserInfo.AdminUserName;
                return RedirectToAction("Index", "Hakan/Hakan");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
    }
}