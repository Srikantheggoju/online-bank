using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class OnlineBank2DbContext : DbContext
    {
        public OnlineBank2DbContext (DbContextOptions<OnlineBank2DbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;
    }
