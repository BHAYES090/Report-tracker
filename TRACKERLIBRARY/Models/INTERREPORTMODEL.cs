using System;
using System.Collections.Generic;
using System.Text;

namespace TRACKERLIBRARY.Models
{
    public class INTERREPORTMODEL
    {
        public int Id { get; internal set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
        public DateTime CreateDate { get; set; }
        public INTERREPORTMODEL()
        {
            
        }
        public INTERREPORTMODEL(string userName, string emailAddress, string phoneNumber, 
            string commentBox, DateTime createDate)
        {
            UserName = userName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            CommentBox = commentBox;
            CreateDate = createDate;
        }
    }
}
