using MySqlConnector;

namespace FSD.Infrastructure.Utility
{
    public static class DbUtility
    {
        public static void AddParemeter(this MySqlParameterCollection parameters, string paramName, object paramValue)
        {
            parameters.AddWithValue(paramName, paramValue);
        }
    }
}
