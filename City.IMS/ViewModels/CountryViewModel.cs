using City.IMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace City.IMS.ViewModels
{
    public class CountryViewModel
    {
        public List<Country> countries { get; set; }
    }
    public class CountryListingViewModel
    {
        public List<Country> countries { get; set; }
        public string CountryName { get; set; }
        public Pager Pager { get; set; }
        public List<Citymodel> Cities { get; set; }
    }
}