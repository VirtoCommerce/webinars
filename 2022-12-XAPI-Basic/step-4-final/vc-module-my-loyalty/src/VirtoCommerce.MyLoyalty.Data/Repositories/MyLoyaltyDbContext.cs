using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;

namespace VirtoCommerce.MyLoyalty.Data.Repositories;

public class MyLoyaltyDbContext : DbContextWithTriggers
{
    public MyLoyaltyDbContext(DbContextOptions<MyLoyaltyDbContext> options)
        : base(options)
    {
    }

    protected MyLoyaltyDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<MyLoyaltyEntity>().ToTable("MyLoyalty").HasKey(x => x.Id);
        //modelBuilder.Entity<MyLoyaltyEntity>().Property(x => x.Id).HasMaxLength(128).ValueGeneratedOnAdd();
    }
}
