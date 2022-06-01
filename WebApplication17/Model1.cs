using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication17
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CATALOGUE> CATALOGUE { get; set; }
        public virtual DbSet<CATEGORIE> CATEGORIE { get; set; }
        public virtual DbSet<CLASSIFICATION> CLASSIFICATION { get; set; }
        public virtual DbSet<DEPOT> DEPOT { get; set; }
        public virtual DbSet<ECRIVAIN> ECRIVAIN { get; set; }
        public virtual DbSet<EDITEUR> EDITEUR { get; set; }
        public virtual DbSet<OUVRAGE> OUVRAGE { get; set; }
        public virtual DbSet<STOCKER> STOCKER { get; set; }
        public virtual DbSet<TARIFER> TARIFER { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATALOGUE>()
                .HasMany(e => e.TARIFER)
                .WithRequired(e => e.CATALOGUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLASSIFICATION>()
                .Property(e => e.LIBRUB)
                .IsUnicode(false);

            modelBuilder.Entity<DEPOT>()
                .Property(e => e.NOMDEP)
                .IsUnicode(false);

            modelBuilder.Entity<DEPOT>()
                .Property(e => e.ADRDEP)
                .IsUnicode(false);

            modelBuilder.Entity<DEPOT>()
                .Property(e => e.CPDEP)
                .IsUnicode(false);

            modelBuilder.Entity<DEPOT>()
                .Property(e => e.VILLEDEP)
                .IsUnicode(false);

            modelBuilder.Entity<DEPOT>()
                .HasMany(e => e.STOCKER)
                .WithRequired(e => e.DEPOT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ECRIVAIN>()
                .Property(e => e.PRENOMECR)
                .IsUnicode(false);

            modelBuilder.Entity<ECRIVAIN>()
                .Property(e => e.NOMECR)
                .IsUnicode(false);

            modelBuilder.Entity<ECRIVAIN>()
                .Property(e => e.PAYSECR)
                .IsUnicode(false);

            modelBuilder.Entity<ECRIVAIN>()
                .Property(e => e.LANGUECR)
                .IsUnicode(false);

            modelBuilder.Entity<ECRIVAIN>()
                .HasMany(e => e.OUVRAGE)
                .WithMany(e => e.ECRIVAIN)
                .Map(m => m.ToTable("ECRIRE").MapLeftKey("NUMECR").MapRightKey("NUMOUVR"));

            modelBuilder.Entity<EDITEUR>()
                .Property(e => e.NOMED)
                .IsUnicode(false);

            modelBuilder.Entity<EDITEUR>()
                .Property(e => e.ADRED)
                .IsUnicode(false);

            modelBuilder.Entity<OUVRAGE>()
                .Property(e => e.NOMOUVR)
                .IsUnicode(false);

            modelBuilder.Entity<OUVRAGE>()
                .Property(e => e.NOMED)
                .IsUnicode(false);

            modelBuilder.Entity<OUVRAGE>()
                .HasMany(e => e.STOCKER)
                .WithRequired(e => e.OUVRAGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OUVRAGE>()
                .HasMany(e => e.TARIFER)
                .WithRequired(e => e.OUVRAGE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.hash)
                .IsUnicode(false);
        }
    }
}
