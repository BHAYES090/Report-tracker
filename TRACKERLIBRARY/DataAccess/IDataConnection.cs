using System;
using System.Collections.Generic;
using System.Text;
using TRACKERLIBRARY.models;
using TRACKERLIBRARY.Models;

namespace TRACKERLIBRARY.DataAccess
{
    public interface IDataConnection
    {
        INTERREPORTMODEL CreateInterReport(INTERREPORTMODEL model);
    }
}
