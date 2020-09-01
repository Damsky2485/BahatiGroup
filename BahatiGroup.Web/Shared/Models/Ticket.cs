using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace BahatiGroup.Web.Shared
{
   public class Ticket
    {
        public Ticket()
        {
            TicketStatuses = new HashSet<TicketStatus>();
        }

        [Key]
        public int TicketId { get; set; }
        public DateTime? Age { get; set; }
        public string SummaryDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime HoursWorked { get; set; }
        public DateTime LastUpdate { get; set; }
        public Source Source { get; set; }
        public bool CustomerUpDated { get; set; }       
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<TicketStatus> TicketStatuses { get; set; }


    }
}
