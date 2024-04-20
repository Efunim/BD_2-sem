using System.Data.Entity;

namespace BD_6
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ShopEntities")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
    }
}
