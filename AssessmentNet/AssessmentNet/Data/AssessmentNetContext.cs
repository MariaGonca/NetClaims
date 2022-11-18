using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssessmentNet.Models;

namespace AssessmentNet.Data
{
    public class AssessmentNetContext : DbContext
    {
        public AssessmentNetContext (DbContextOptions<AssessmentNetContext> options)
            : base(options)
        {
        }

        public DbSet<AssessmentNet.Models.Owner> Owner { get; set; } = default!;

        public DbSet<AssessmentNet.Models.Vehicle> Vehicle { get; set; }

        public DbSet<AssessmentNet.Models.Claim> Claim { get; set; }
    }
}
