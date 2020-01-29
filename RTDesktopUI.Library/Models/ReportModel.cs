using System;

namespace RTDesktopUI.Library.Models
{
    public class ReportModel
    {

        public int Id { get; set; } 
        public string CreateDate { get; set; } = DateTime.Now.ToString("MM DD YYYY HH:MM:SS");
        public string UserNameEmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public ReportModel()
        {

        }
        public ReportModel(string createDate, string userNameEmailAddress, 
            string phoneNumber, string commentBox)
        {
            CreateDate = createDate;
            UserNameEmailAddress = userNameEmailAddress;
            PhoneNumber = phoneNumber;
            CommentBox = commentBox;
        }
    }
}
