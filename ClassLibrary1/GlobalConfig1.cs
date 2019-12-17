using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class GlobalConfig1
    {
        public static List<IDataConnection1> Connections { get; private set; }
            = new List<IDataConnection1>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                // TODO -- Set up SQL Connector Properly
                SQLConnector1 sql = new SQLConnector1();
                Connections.Add(sql);
            }
            if (textFiles == true)
            {
                // TODO -- Set up the text connector proerly, 
                // TODO -- double check to see if TextConnector is the same
                // TODO -- as TextConnection
                TextConnector1 text = new TextConnector1();
                Connections.Add(text);
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
