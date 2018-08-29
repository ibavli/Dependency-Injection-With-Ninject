using DependencyInjectionWithNinject.Dal.Abstract;
using DependencyInjectionWithNinject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectionWithNinject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IAdminDal _adminDal;
        public HomeController(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public ActionResult Index()
        {
            Admin admin = _adminDal.GetAdmin("admin");
            if (admin == null)
            {
                Admin sampleAdmin = new Admin()
                {
                    UserName = "admin",
                    Name = "ibrahim",
                    Surname = "bavlı"
                };
                _adminDal.CreateAdmin(sampleAdmin);
            }
            Admin _admin = _adminDal.GetAdmin("admin");
            return View(_admin);
        }
    }
}