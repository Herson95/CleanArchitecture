namespace NorthWind.EFCore.Repositories.DataContexts
{
    public class NorthWindSaleContext : DbContext
    {
        public NorthWindSaleContext(DbContextOptions<NorthWindSaleContext> options) : base(options)
        {

        }
       
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

