

namespace SignalRCS.Persistence;

static class Configuration
{
    static private ConfigurationManager Configurations
    {
        get
        {
            ConfigurationManager configurationManager = new();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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
