using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BahatiGroup.Web.Shared
{
    public class Province
    {
        public Province()
        {
            Companies = new HashSet<Company>();
        }

        [Key]
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}