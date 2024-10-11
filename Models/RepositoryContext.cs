using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace StoreApp.Models
{
    public class RepositoryContext:DbContext
    {
        public DbSet<Product>Products{get; set;}
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options){
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){ProductId=1, ProductName="Computer", Price=17_000},
                new Product(){ProductId=2, ProductName="Keyboard", Price=5_000},
                new Product(){ProductId=3, ProductName="Mouse", Price=1_000},
                new Product(){ProductId=4, ProductName="Monitor", Price=10_000},
                new Product(){ProductId=5, ProductName="Deck", Price=3_000}
            );
        }

    }
}