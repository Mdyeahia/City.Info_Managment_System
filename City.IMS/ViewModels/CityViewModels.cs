using City.IMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace City.IMS.ViewModels
{
    public class CitycreateViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int Dwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int countryId { get; set; }
        public List<Country> countries { get; set; }
    }
    public class CityListViewModel
    {
        public List<Citymodel> citymodels { get; set; }
    }
}