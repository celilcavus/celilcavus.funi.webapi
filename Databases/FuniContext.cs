using Funi.Configurations;
using Funi.Models;
using Microsoft.EntityFrameworkCore;

namespace Funi.Databases;

public class FuniContext : DbContext
{
    // public FuniContext(DbContextOptions<FuniContext> dbContextOptions) : base(dbContextOptions)
    // {

    // }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Communication> Communications { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    //==>
    public DbSet<OurTeam> OurTeams { get; set; }
    public DbSet<Title> Titles { get; set; }
    //==>
    public DbSet<Services> Services { get; set; }
    //==>
    public DbSet<Facebook> Facebooks { get; set; }
    public DbSet<Instagram> Instagrams { get; set; }
    public DbSet<Twitter> Twitters { get; set; }
    public DbSet<Linkedin> Linkedins { get; set; }
    //==>
    public DbSet<Testimonials> Testimonials { get; set; }
    public DbSet<WhyChooseUs> WhyChooseUs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ShopConfiguration());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=91.151.90.223;Database=funi;User Id=celil;Password=Xk3cu?305;TrustServerCertificate=True;");
    }
    
}