using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCORECompany.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETCORECompany.Models.Employee> Employee { get; set; }
        public DbSet<ASPNETCORECompany.Models.Manager> Manager { get; set; }
    }
}
