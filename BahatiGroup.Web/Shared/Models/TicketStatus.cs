using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BahatiGroup.Web.Shared
{
  public class TicketStatus
    {
       
        [Key]
        public int TicketStatusId { get; set; }
        public string TicketStatusName { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public virtual Ticket Tickets { get; set; }

    }
}
