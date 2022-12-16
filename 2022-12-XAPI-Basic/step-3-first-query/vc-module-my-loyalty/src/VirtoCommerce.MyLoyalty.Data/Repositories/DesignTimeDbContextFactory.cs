using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace VirtoCommerce.MyLoyalty.Data.Repositories;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyLoyaltyDbContext>
{
    public MyLoyaltyDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<MyLoyaltyDbContext>();

        builder.UseSqlServer("Data Source=(local);Initial Catalog=VirtoCommerce3;Persist Security Info=True;User ID=virto;Password=virto;MultipleActiveResultSets=True;Connect Timeout=30");

        return new MyLoyaltyDbContext(builder.Options);
    }
}
