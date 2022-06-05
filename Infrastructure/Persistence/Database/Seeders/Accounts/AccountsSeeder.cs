namespace Infrastructure.Persistence.Database.Seeders.Accounts;

public class AccountsSeeder : ISeeder
{
    private readonly List<ISeeder> _seeders;

    public AccountsSeeder()
    {
        _seeders = new List<ISeeder>
        {
            new MainCashDrawerSeeder(),
            new MainSalesSeeder(),
            new MainPurchasesSeeder()
        };
    }
    
    public void Seed(ApplicationDbContext dbContext)
    {
        _seeders.ForEach(seeder => seeder.Seed(dbContext));
    }
}