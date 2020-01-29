using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
        public async Task PostReport(string CreateDate, string UserNameEmailAddress, string PhoneNumber, string CommentBox)
        {
            var report = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("CreateDate", CreateDate),
                new KeyValuePair<string, string>("UserNameEmailAddress", UserNameEmailAddress),
                new KeyValuePair<string, string>("PhoneNumber", PhoneNumber),
                new KeyValuePair<string, string>("CommentBox", CommentBox)
            });
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsync("/api/Report", report))
            {
                if (response.IsSuccessStatusCode)
                {
                    await response.Content.ReadAsAsync<Task>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
