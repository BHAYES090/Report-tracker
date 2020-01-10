using TRACKERLIBRARY.Models;

namespace TRACKERLIBRARY.DataAccess
{
    public interface IDataConnection
    {
        INTERREPORTMODEL CreateInterReport(INTERREPORTMODEL model);
    }
}
