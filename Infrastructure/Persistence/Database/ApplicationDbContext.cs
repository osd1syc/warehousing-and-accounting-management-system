using Infrastructure.Persistence.Database.Models;
using Infrastructure.Persistence.Database.Models.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Database;

public class ApplicationDbContext : IdentityDbContext<ApplicationIdentityUser, IdentityRole<int>, int>
{
    public DbSet<ManufacturerDb> Manufacturers { get; set; } = null!;
    public DbSet<CategoryDb> Categories { get; set; } = null!;
    public DbSet<UnitDb> Units { get; set; } = null!;
    public DbSet<CurrencyDb> Currencies { get; set; } = null!;
    public DbSet<ApplicationSettingDb> Settings { get; set; } = null!;
    public DbSet<ProductDb> Products { get; set; } = null!;
    public DbSet<WarehouseDb> Warehouses { get; set; }
    public DbSet<StoragePlaceDb> StoragePlaces { get; set; }
    public DbSet<AccountDb> Accounts { get; set; } = null!;

    public DbSet<ProductMovementDb> ProductMovements { get; set; }
    public DbSet<CurrencyAmountDb> CurrencyAmounts { get; set; }
    public DbSet<InvoiceDb> Invoices { get; set; }
    public DbSet<PaymentDb> payments { get; set; }
    
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyGlobalFilters<ISoftDeletable>(e => !e.IsDeleted);
    }
}