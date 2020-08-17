using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppointmentsSite
{
    public partial class ISAD251_JReesContext : DbContext
    {
        public ISAD251_JReesContext()
        {
        }

        public ISAD251_JReesContext(DbContextOptions<ISAD251_JReesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=socem1.uopnet.plymouth.ac.uk;Database=ISAD251_JRees;User Id=JRees; Password=ISAD251_22217940");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK__Appointm__8ECDFCA2F70F6498");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("AppointmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmentDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentTarget)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentTime).HasColumnType("date");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
