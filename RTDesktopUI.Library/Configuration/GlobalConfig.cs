using RTDesktopUI.Library.DataAndSQL;
using System.Configuration;

namespace RTDesktopUI.Library.Configuration
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }


        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                //TODO - Configure Text Connector properly with global Config. 
                //TextConnector text = new TextConnector();
                //Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
           
        }
    }

}
