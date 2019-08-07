using Microsoft.EntityFrameworkCore;

namespace PiratesDataBases.Models
{
  public class PiratesDataBasesContext : DbContext
  {
    // public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Ship> Ships { get; set; }
    
    public PiratesDataBasesContext(DbContextOptions options) : base(options) { }
  }
}
