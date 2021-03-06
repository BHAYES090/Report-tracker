﻿using System;

namespace DataManager1.Models
{
    public class ReportModel
    {
        public string Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("MM DD YYYY HH:MM:SS");
        public string UserNameEmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CommentBox { get; set; }
    }
}