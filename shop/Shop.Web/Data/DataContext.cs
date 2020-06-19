
namespace Shop.Web.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;
    public class DataContext:DbContext
    {
        public DbSet<Product> Products { set; get; }

        public DataContext(DbContextOptions<DataContext>options): base(options)
        {

        }
    }
}
