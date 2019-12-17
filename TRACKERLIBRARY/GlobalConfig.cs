using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TRACKERLIBRARY.DataAccess;

namespace TRACKERLIBRARY
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }
            = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                // TODO -- Set up SQL Connector Properly
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }
            if (textFiles == true)
            {
                // TODO -- Set up the text connector proerly, 
                // TODO -- double check to see if TextConnector is the same
                // TODO -- as TextConnection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
