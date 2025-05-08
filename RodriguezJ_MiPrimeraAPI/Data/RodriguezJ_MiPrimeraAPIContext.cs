using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RodriguezJ_MiPrimeraAPI.Models;

namespace RodriguezJ_MiPrimeraAPI.Data
{
    public class RodriguezJ_MiPrimeraAPIContext : DbContext
    {
        public RodriguezJ_MiPrimeraAPIContext (DbContextOptions<RodriguezJ_MiPrimeraAPIContext> options)
            : base(options)
        {
        }

        public DbSet<RodriguezJ_MiPrimeraAPI.Models.Cuenta> Cuenta { get; set; } = default!;
    }
}
