using Microsoft.EntityFrameworkCore;


namespace BlazorBasic.PizzaProject.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<PizzaSpecial> Specials { get; set; }
    }
}
