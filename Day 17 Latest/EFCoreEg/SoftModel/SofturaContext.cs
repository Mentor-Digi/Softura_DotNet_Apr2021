using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreEg.SoftModel
{
    public partial class SofturaContext : DbContext
    {
        public SofturaContext()
        {
        }

        public SofturaContext(DbContextOptions<SofturaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SofturaEmp> SofturaEmps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Softura;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<SofturaEmp>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__SofturaE__D9509F6D603A3953");

                entity.ToTable("SofturaEmp");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Phno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phno");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
