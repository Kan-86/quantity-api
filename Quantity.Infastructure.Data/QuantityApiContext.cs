using Api.Core.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Quantity.Infastructure.Data.SQLRepositories
{
    public class QuantityApiContext: DbContext
    {
        public QuantityApiContext(DbContextOptions<QuantityApiContext> opt) : base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Overrides the modelbuilder
            base.OnModelCreating(modelBuilder);




            // configures one-to-many relationship
            // modelBuilder.Entity<CompanyGroup>()
            //    .HasMany(g => g.Accounts)
            //    .WithOne(s => s.CompanyGroup)
            //    .IsRequired();

        }

        //Tables
        public DbSet<CompanyGroup> CompanyGroup { get; set; }
    }
}
