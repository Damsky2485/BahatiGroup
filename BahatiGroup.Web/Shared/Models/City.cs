using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BahatiGroup.Web.Shared
{
    public class City
    {
        public City()
        {
            Companies = new HashSet<Company>();
            Addresses = new HashSet<Address>();
            Contacts = new HashSet<Contact>();
        }

        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}