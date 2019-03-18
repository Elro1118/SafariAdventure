using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SafariAdventure
{
  public partial class safariormsContext : DbContext
  {
    public safariormsContext()
    {
    }

    public safariormsContext(DbContextOptions<safariormsContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=safariorms;user id=dev;password=dev");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { }

    public DbSet<SeenAnimals> SeenAnimals { get; set; }
  }
}
