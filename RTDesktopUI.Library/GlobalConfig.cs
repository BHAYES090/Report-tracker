
using RTDesktopUI.Library.Configuration;
using RTDesktopUI.Library.DataAndSQL;
using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO  set up SQL Connector properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO - do something
                TextConnetor text = new TextConnetor();
                Connection = text;
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
