using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BahatiGroup.Web.Shared
{
   public class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
            Provinces = new HashSet<Province>();
            Companies = new HashSet<Company>();

        }

        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
