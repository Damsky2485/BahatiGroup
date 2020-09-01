using Microsoft.EntityFrameworkCore;


namespace BahatiGroup.Web.Shared.DAL
{
    public class BahatiDbContext : DbContext
    {
        //public virtual DbSet<Car> Cars { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<UserContact> UserContacts { get; set; }
        public BahatiDbContext(DbContextOptions<BahatiDbContext> options)
        : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Contact> Contacts { get; set; }

    }
}
