using Microsoft.EntityFrameworkCore;
using PruebaTec.Models;

public class PruebaTecContext : DbContext
{
    public PruebaTecContext(DbContextOptions<PruebaTecContext> options) : base(options) { }

    public DbSet<Estudiante> Estudiantes => Set<Estudiante>();
    public DbSet<Carrera> Carreras => Set<Carrera>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Estudiante>().HasIndex(e => e.CURP).IsUnique();

        modelBuilder.Entity<Estudiante>().HasOne(e => e.Carrera).WithMany(c => c.Estudiantes).HasForeignKey(e => e.IdCarrera);

        modelBuilder.Entity<Carrera>().HasKey(c => c.IdCarrera);
    }
    }