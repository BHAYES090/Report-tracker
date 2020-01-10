using Enums;
using RTDesktopUI.Library.DataAndSQL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.Configuration
{

    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; }
            

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO -- Set up SQL Connector Properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            //else if (db == DatabaseType.TextFile)
            //{
            //    // TODO -- Set up the text connector proerly, 
            //    // TODO -- double check to see if TextConnector is the same
            //    // TODO -- as TextConnection
            //    TextConnector text = new TextConnector();
            //    Connection = text;
            //}
        }
        public static string CnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
           
        }
    }

}
