using Microsoft.EntityFrameworkCore;
using API_Test_Demo.Entities;

namespace API_Test_Demo.Data
{
    public class DbContextClass : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass>
options) : base(options)
        {

        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
