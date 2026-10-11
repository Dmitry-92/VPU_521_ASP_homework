using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy2.Models;

namespace Academy2.Data
{
    public class Academy2Context : DbContext
    {
        public Academy2Context (DbContextOptions<Academy2Context> options)
            : base(options)
        {
        }

        public DbSet<Academy2.Models.Direction> Directions { get; set; } = default!;
    }
}
