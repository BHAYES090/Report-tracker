using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.API
{
    public interface IReportEndpoint
    {
        
        Task<ReportModel> PostReport(string CreateDate, string UserNameEmailAddress,  string PhoneNumber, string CommentBox);

        //DateTime CreateDate { get; set; } = DateTime.UtcNow;
        //Task<List<ReportModel>> GetReportModel();
    }
}