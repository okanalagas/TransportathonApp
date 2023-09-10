using Microsoft.Extensions.Configuration;

namespace TransportathonApp.Persistence;

static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/TransportathonApp.API"));  
            configurationManager.AddJsonFile("appsettings.json");                                                                   
            return configurationManager.GetConnectionString("TransportathonAppDBConnection");
        }
    }
}
