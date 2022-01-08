using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PizzeriaModel
{
    public partial class PizzeriaEntitiesModel : DbContext
    {
        public PizzeriaEntitiesModel()
            : base("name=PizzeriaEntitiesModel")
        {
        }

        public virtual DbSet<Angajati> Angajatis { get; set; }
        public virtual DbSet<Orar> Orars { get; set; }
        public virtual DbSet<Program> Programs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Angajati>()
                .HasMany(e => e.Programs)
                .WithOptional(e => e.Angajati)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Orar>()
                .HasMany(e => e.Programs)
                .WithOptional(e => e.Orar)
                .WillCascadeOnDelete();
        }
    }
}
