using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Practice.API.Infrastructure
{
    using Microsoft.EntityFrameworkCore;
    using Model;
    //   using EntityConfigurations;

    using Microsoft.EntityFrameworkCore.Design;

    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions<PracticeContext> options) : base(options)
        {
        }
        public DbSet<PracticeItem> PracticeItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           //builder.ApplyConfiguration(new PracticeBrandEntityTypeConfiguration());
            //builder.ApplyConfiguration(new PracticeTypeEntityTypeConfiguration());
            //builder.ApplyConfiguration(new PracticeItemEntityTypeConfiguration());
        }
    }
    public class PracticeContextDesignFactory : IDesignTimeDbContextFactory<PracticeContext>
    {
        public PracticeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PracticeContext>()
                .UseSqlServer("Server=.;Initial Practice=Microsoft.eShopOnContainers.Services.PracticeDb;Integrated Security=true");

            return new PracticeContext(optionsBuilder.Options);
        }
    }
}
