using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BahatiGroup.Web.Shared
{
   public class Company
    {
        public Company()
        {
            Addresses = new HashSet<Address>();
            Sites = new HashSet<Site>();
            
        }

        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPerson { get; set; }
        public Territory Territory { get; set; }
        public Market Market { get; set; }      
        public Entered Entered { get; set; }
        public int ProvinceId { get; set; }
        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        


    }
}
