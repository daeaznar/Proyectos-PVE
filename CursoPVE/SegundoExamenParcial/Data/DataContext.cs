using System.Data.Entity;

namespace SegundoExamenParcial.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<DanceChampionship> DanceChampionship { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanceChampionship>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
