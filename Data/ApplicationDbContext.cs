using BookstoreMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace BookstoreMvc.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = Guid.Parse("4f3fc45e-6b5e-429a-8751-252febdd55e6"), Name = "ScienceFiction", DisplayOrder = 1}, 
            new Category { Id = Guid.Parse("c4547d44-266b-4ca3-a23e-d95d9e62f937"), Name = "Drama", DisplayOrder = 2},
            new Category { Id = Guid.Parse("e5fafa9f-7876-4009-bdcc-fb60f1786a38"), Name = "Criminal", DisplayOrder = 3},
            new Category { Id = Guid.Parse("651c344c-1fed-4141-a1a6-a3e304ce0878"), Name = "History", DisplayOrder = 4}
        );
    }
}