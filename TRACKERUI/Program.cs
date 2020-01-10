using System;
using System.Windows.Forms;
using TRACKERLIBRARY.DataAccess;

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
            TRACKERLIBRARY.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new CREATEREPORTFORM());
        }
    }
}
