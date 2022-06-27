using Microsoft.EntityFrameworkCore;
using P9.Server.Controllers;
using P9.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P9.Server.DB
{
    public class ClotheDBContext : DbContext
    {
        public ClotheDBContext(DbContextOptions<ClotheDBContext> options)
            : base(options)
        {}
        public DbSet<Clothe> Clothes {get; set;}
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}