using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CWheelsAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CWheelsAPI.Data
{
    public class CWheelsDBContext: DbContext
    {
        public CWheelsDBContext(DbContextOptions<CWheelsDBContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
