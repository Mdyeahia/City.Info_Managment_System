using City.IMS.Models;
using City.IMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace City.IMS.Controllers
{
    public class CityController : Controller
    {
        CityDbContext context = new CityDbContext();
        // GET: City
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Create()
        {
            CitycreateViewModels model = new CitycreateViewModels();
            model.countries = context.Countries.ToList();
            return PartialView(model);

        }
        [HttpPost]
        public JsonResult Create(CitycreateViewModels model)
        {
            JsonResult result = new JsonResult();
            if (ModelState.IsValid)
            {
                var newCity = new Citymodel();
                newCity.Name = model.Name;
                newCity.About = model.About;
                newCity.Dwellers = model.Dwellers;
                newCity.Location = model.Location;
                newCity.Weather = model.Weather;
                newCity.Country = context.Countries.Find(model.countryId);

                context.Citymodels.Add(newCity);
                context.SaveChanges();
                
                result.Data = new { success = true };
            }
            else
            {
                result.Data = new { success = false, message = "Invalid inputs." };
            }
            return result;
        }
        public ActionResult CityTable()
        {
            CityListViewModel model = new CityListViewModel();
            model.citymodels = context.Citymodels.ToList();

            return PartialView(model);
        }
    }
}