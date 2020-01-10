using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.DataAndSQL
{
    public class TextConnetor : IDataConnection
    {
        public ReportModel CreateReport(ReportModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
