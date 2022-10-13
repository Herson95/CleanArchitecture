namespace NorthWind.EFCore.Repositories.DataContexts
{
    internal class NorthWindContext : DbContext
    {
        //dotnet ef migrations add InitialCreate -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -c NorthWindContext
        //dotnet ef database update -p NorthWind.EFCore.Repositories -s NorthWind.EFCore.Repositories -c NorthWindContext


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            optionsBuilder.UseSqlServer("Server=localhost;Database=NorthwindDB;User Id=SA;password=123456a@;Trusted_Connection=False;MultipleActiveResultSets=true;");
       }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

