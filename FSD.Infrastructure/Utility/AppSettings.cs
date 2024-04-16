using FSD.Infrastructure.Configuration;
using Microsoft.Extensions.Options;
using MySqlConnector;

namespace FSD.Infrastructure.Utility
{
    public interface IAppSettings
    {
        MySqlConnection GetConnection();
    }

    public class AppSettings : IAppSettings
    {
        private readonly IOptions<DbSettings> dbSettings;
        public AppSettings(IOptions<DbSettings> dbSettings)
        {
            this.dbSettings = dbSettings;
        }

        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(this.dbSettings.Value.FSDDBConnString);
            connection.Open();
            return connection;
        }
    }
}
