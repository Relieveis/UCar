using System;
using Dapper;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace Honotop.WMS.Data.Domins
{
    public class DBConnention
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private static readonly string ProviderFactoryString = ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName;
        private static DbProviderFactory df = null;
        public static IDbConnection GetDbConnection()
        {
            if (df == null)
                df = DbProviderFactories.GetFactory(ProviderFactoryString);
            var connection = df.CreateConnection();
            connection.ConnectionString = ConnectionString;//GetConnectionString();
            connection.Open();
            return connection;
        }


        public static string GetConnectionString()
        {
            return string.Empty;
        }
    }
}
