using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auction>()
            .HasOne(a => a.Item)
            .WithOne(i => i.Auction)
            .HasForeignKey<Item>(i => i.AuctionId);

        modelBuilder.Entity<Auction>()
            .Property(a => a.Status)
            .HasConversion<string>();

        modelBuilder.Entity<Item>()
            .Property(i => i.Color)
            .HasConversion<string>();
    }
}
