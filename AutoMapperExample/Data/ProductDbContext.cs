using AutoMapperExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperExample.Data
{
    public class ProductDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {

        }
    }
}
