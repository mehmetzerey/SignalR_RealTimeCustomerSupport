
namespace SignalR.Persistence;

static class Configuration
{
    static private ConfigurationManager Configurations
    {
        get
        {
            ConfigurationManager configurationManager = new();
#pragma warning disable CS8604 // Possible null reference argument.
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
#pragma warning restore CS8604 // Possible null reference argument.
            configurationManager.AddJsonFile(path + "/appsettings.json");
            return configurationManager;
        }
    }
    static public string ConnectionStringIdentity
    {
        get
        {
            return Configurations.GetConnectionString("Identity");
        }
    }
}
