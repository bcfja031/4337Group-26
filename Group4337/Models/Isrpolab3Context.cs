using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Group4337.Models;

public partial class Isrpolab3Context : DbContext
{
    public Isrpolab3Context()
    {
    }

    public Isrpolab3Context(DbContextOptions<Isrpolab3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-M0GO7VS7;Database=ISRPOLab3;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC079AC978B0");

            entity.Property(e => e.Post)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserLogin)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
