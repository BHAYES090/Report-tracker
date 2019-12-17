using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary2
{

    public static class GlobalConfig2
    {
        public static IDataConnection2 Connection { get; private set; }
            

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO -- Set up SQL Connector Properly
                SQLConnector2 sql = new SQLConnector2();
                Connection =sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                // TODO -- Set up the text connector proerly, 
                // TODO -- double check to see if TextConnector is the same
                // TODO -- as TextConnection
                TextConnector2 text = new TextConnector2();
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
           
        }
    }

}
