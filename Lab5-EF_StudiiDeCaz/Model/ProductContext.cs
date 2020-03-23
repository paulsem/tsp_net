using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace EF_StudiiDeCaz.Model
{
    class ProductContext : DbContext
    {
        public ProductContext() : base("name=ProductContext") 
        { 
        }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                    .Map(m =>
                    {
                        m.Properties(p => new { p.SKU, p.Description, p.Price });
                        m.ToTable("Product", "BazaDeDate");
                    })
                    .Map(m =>
                    {
                        m.Properties(p => new { p.SKU, p.ImageUrl });
                        m.ToTable("ProductWebInfo", "BazaDeDate");
                    });
        }
    }
}
