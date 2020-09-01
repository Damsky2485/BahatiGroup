using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BahatiGroup.Web.Shared
{
    public class Site
    {
        public Site()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int SiteId { get; set; }
        public string SiteName { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}