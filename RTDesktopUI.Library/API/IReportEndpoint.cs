using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.API
{
    public interface IReportEndpoint
    {
        Task<ReportModel> PostReport(string UserNameEmailAddress, string PhoneNumber, string CommentBox, DateTime CreateDate);
       
        //Task<List<ReportModel>> GetReportModel();
    }
}