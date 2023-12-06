using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Puppy.Models;

    public class RazorPagesPuppyDbContext : DbContext
    {
        public RazorPagesPuppyDbContext (DbContextOptions<RazorPagesPuppyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Puppy.Models.Puppy> Puppy { get; set; } = default!;
    }
