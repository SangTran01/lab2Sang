using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab1.Models;

namespace lab1.Models
{
    public class lab1Context : DbContext
    {
        public lab1Context (DbContextOptions<lab1Context> options)
            : base(options)
        {
        }

        public DbSet<lab1.Models.Car> Car { get; set; }

        public DbSet<lab1.Models.Member> Member { get; set; }
    }
}
