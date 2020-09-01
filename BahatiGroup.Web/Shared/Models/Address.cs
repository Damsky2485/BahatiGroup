using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BahatiGroup.Web.Shared
{
   public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZipCode { get; set; }
        public string PostalAddress { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public  virtual Company Company { get; set; }
    }
}
