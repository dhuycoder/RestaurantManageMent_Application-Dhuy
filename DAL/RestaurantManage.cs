using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOO;
using Microsoft.Identity.Client;
namespace DAL
{
    public class RestaurantManage : DbContext
    {
        public DbSet<Food> foods { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<FoodSize> foodSizes { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
        public DbSet<Food_Order> Food_Order { get; set; }
        public DbSet<Bill> Bill { get; set; }

        String connectionString = "Data source =localhost,1433; Initial Catalog = FastFood_RestaurantManagement;User Id =sa;Password = 123;TrustServerCertificate=True ";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
