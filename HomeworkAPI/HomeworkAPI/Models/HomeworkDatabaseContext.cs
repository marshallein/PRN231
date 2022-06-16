using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HomeworkAPI.Models
{
    public partial class HomeworkDatabaseContext : DbContext
    {
        public HomeworkDatabaseContext()
        {
        }

        public HomeworkDatabaseContext(DbContextOptions<HomeworkDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationType> ReservationTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=(local); database=HomeworkDatabase;uid=sa;pwd=mongtoqua1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.EndLocation).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartLocation).HasMaxLength(50);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_ReservationType");
            });

            modelBuilder.Entity<ReservationType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("ReservationType");

                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
