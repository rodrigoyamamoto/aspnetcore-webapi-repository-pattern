using Microsoft.EntityFrameworkCore;

namespace aspnetcore_webapi_repository_pattern.data.models;

public class RepositoryPatternDataContext : DbContext
{
    public RepositoryPatternDataContext(DbContextOptions<RepositoryPatternDataContext> options) : base(options)
    { }

    public virtual DbSet<Customer> Customer { get; set; } = null!;
    public virtual DbSet<Product> Product { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });
    }
}