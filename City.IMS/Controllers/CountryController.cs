using City.IMS.Models;
using City.IMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace City.IMS.Controllers
{
    public class CountryController : Controller
    {
        CityDbContext context = new CityDbContext();
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return PartialView();

        }
        [HttpPost]
        public ActionResult Create (Country data)
        {
            
            var model = new Country();
            
            model.Name = data.Name;
            model.About = data.About;

            context.Countries.Add(model);
            context.SaveChanges();
            //Redirect(Request.UrlReferrer.ToString());
            return PartialView();
        }
        public ActionResult CountryTable()
        {
            CountryViewModel model = new CountryViewModel();

            model.countries= context.Countries.ToList();

            return PartialView(model);
        }

    }
}