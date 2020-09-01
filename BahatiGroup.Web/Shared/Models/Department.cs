using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BahatiGroup.Web.Shared
{
   public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
