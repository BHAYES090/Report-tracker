using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.API
{
    public class ReportEndpoint : IReportEndpoint
    {
        private IAPIHelper _apiHelper;
        public ReportEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public async Task<ReportModel> PostReport(string CreateDate, string UserNameEmailAddress, string PhoneNumber, string CommentBox)
        {
            var report = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("CreateDate", CreateDate),
                new KeyValuePair<string, string>("UserNameEmailAddress", UserNameEmailAddress),
                new KeyValuePair<string, string>("PhoneNumber", PhoneNumber),
                new KeyValuePair<string, string>("CommentBox", CommentBox)


            });
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/Report", report))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<ReportModel>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

//        public async Task 
//        {
//            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/InterReport", report))
//            {
//                if (response.IsSuccessStatusCode)
//                {
//                    //var result = await response.Content.ReadAsAsync<List<ReportModel>>();
//                    //return result;
//                }
//                else
//                {
//                    throw new Exception(response.ReasonPhrase);
//                }
//            }
//        }
//    }
//}
