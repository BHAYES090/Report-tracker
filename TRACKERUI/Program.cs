using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary2;

namespace TRACKERUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //initalize database connections
            TrackerLibrary2.GlobalConfig2.InitializeConnections(DatabaseType.Sql);
            Application.Run(new REPORTDASHBOARD());
        }
    }
}
