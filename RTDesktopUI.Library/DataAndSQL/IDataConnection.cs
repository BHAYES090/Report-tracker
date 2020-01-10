using RTDesktopUI.Library.Models;

namespace RTDesktopUI.Library.DataAndSQL
{
    public interface IDataConnection
    {
         ReportModel CreateReport(ReportModel model);
    }
}
