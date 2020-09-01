using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BahatiGroup.Web.Shared
{
   public class Employee
    {
        public Employee()
        {
           
            TicketStatuses = new HashSet<TicketStatus>();
        }

        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
       
        public ICollection<TicketStatus> TicketStatuses { get; set; }
    }
}
