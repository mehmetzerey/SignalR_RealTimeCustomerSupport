using SignalRCS.Persistence.Identity;

namespace SignalRCS.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<SignalRCSIdentiyDbContext>()
                    .AddDefaultTokenProviders();
        services.AddDbContext<SignalRCSIdentiyDbContext>(opt => opt.UseNpgsql(Configuration.ConnectionStringIdentity));
    }
}
