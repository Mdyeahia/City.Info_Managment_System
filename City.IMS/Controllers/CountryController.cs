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
        public JsonResult Create (Country data)
        {
            JsonResult result = new JsonResult();
            if(ModelState.IsValid)
            {
                var model = new Country();

                model.Name = data.Name;
                model.About = data.About;

                context.Countries.Add(model);
                context.SaveChanges();
                
                result.Data = new { success = true };
            }
            else
            {
                result.Data = new { success = false, message = "Invalid inputs." };
            }
            
            return result;
 
        }
        public ActionResult CountryTable()
        {
            CountryViewModel model = new CountryViewModel();

            model.countries= context.Countries.ToList();

            return PartialView(model);
        }

    }
}