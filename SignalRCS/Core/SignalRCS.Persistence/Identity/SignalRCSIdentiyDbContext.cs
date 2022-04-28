
namespace SignalRCS.Persistence.Identity;

public class SignalRCSIdentiyDbContext : IdentityDbContext<ApplicationUser>
{
    public SignalRCSIdentiyDbContext(DbContextOptions<SignalRCSIdentiyDbContext> options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}

