using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArchPointPHR.Models
{
    public class ArchPointPHRContext : DbContext
    {
        public ArchPointPHRContext (DbContextOptions<ArchPointPHRContext> options)
            : base(options)
        {
        }

        public DbSet<ArchPointPHR.Models.Medication> Medication { get; set; }
    }
}
