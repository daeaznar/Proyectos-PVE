using System.Data.Entity;

namespace ImagesWindow.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Gamer> Gamer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gamer>()
                .Property(e => e.GamerTag)
                .IsFixedLength();
        }
    }
}
