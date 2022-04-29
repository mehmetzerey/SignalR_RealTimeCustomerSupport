namespace SignalR.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<SignalRIdentiyDbContext>()
                    .AddDefaultTokenProviders();
        services.AddDbContext<SignalRIdentiyDbContext>(opt => opt.UseNpgsql(Configuration.ConnectionStringIdentity));
    }
}
