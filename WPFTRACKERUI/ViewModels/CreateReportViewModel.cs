using Caliburn.Micro;
using Dapper;
using RTDesktopUI.Library.API;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WPFTRACKERUI.ViewModels
{
    public class CreateReportViewModel : Screen
    {
        IReportEndpoint _reportEndpoint;

        public CreateReportViewModel(IReportEndpoint reportEndpoint)
        {
            _reportEndpoint = reportEndpoint;
        }
        private string _createDate;
        private string _userNameEmailAddress;
        private string _phoneNumber;
        private string _commentBox;
        public string CreateDate
        {
            get { return _createDate; }
            set
            {
                _createDate = DateTime.Now.ToString("MM DD YYYY");
                NotifyOfPropertyChange(() => CreateDate);
            }
        }
        public string UserNameEmailAddress
        {
            get { return _userNameEmailAddress; }
            set
            {
                _userNameEmailAddress = value;
                NotifyOfPropertyChange(() => UserNameEmailAddress);
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                NotifyOfPropertyChange(() => PhoneNumber);
            }
        }
        public string CommentBox
        {
            get { return _commentBox; }
            set
            {
                _commentBox = value;
                NotifyOfPropertyChange(() => CommentBox);
            }
        }
        /// <summary>
        /// Well, this has been a very interesting time; figuring out this issue. I'm not sure if I feel comfortable 
        /// with this result. Perhaps Ken Burns' Vietnam documentary on netflix has some how clouded my 
        /// sense of victory and achievement. I feel like I can possibly move on from this topic. 
        /// My goal should be to have this SQL code as far away from the UI as I can. I also need to figure out how to clear those 
        /// textbox values after data has been inserted. It would be nice to also use the API for something else other than logging in
        /// So perhaps I should figure out how to adjust this in a manner that would incorporate _reportEndpoint in a more active role. 
        /// I should be proud, although this issue has left me batter and beaten mentally. A lot of devs have these crazy UI 
        /// designs and I think I should figure out how to spruce up the xaml. 
        /// Pat on the back my guy you did it, just a couple more tweeks away from a fully functioning application. 
        /// Also I have to look up information on SQL Injecttions to ensure that my current system is at a low risk. 
        /// </summary>
        /// <param name="CreateDate"></param>
        /// <param name="UserNameEmailAddress"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="CommentBox"></param>
        public static void CreateReport(string CreateDate, string UserNameEmailAddress, string PhoneNumber, string CommentBox) 
        {
            using (IDbConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=REPORTSDATASQL;Integrated Security=True;"
                                          +"Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                var P = new DynamicParameters();
                P.Add("UserNameEmailAddress", UserNameEmailAddress);
                P.Add("PhoneNumber", PhoneNumber);
                P.Add("CommentBox", CommentBox);
                P.Add("CreateDate", CreateDate);
                P.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spInterReport_Post", P, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
// the relics of many moons of failure can be found below. 
// their graves only serve as a stark reminder of the cost of learning.
// ... and also just for refrence to future solutions. 
//public static void CreateReport(string CreateDate, string UserNameEmailAddress, string PhoneNumber, string CommentBox)
        //{
        //    try
        //    {
        //        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=REPORTSDATASQL;Integrated Security=True;"
        //                                   +"Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        using (SqlCommand command = connection.CreateCommand())
        //        {
        //            command.CommandText = "INSERT INTO dbo.InterReport (UserNameEmailAddress, PhoneNumber, CommentBox, CreateDate) VALUES (@UserNameEmailAddress, @PhoneNumber, @CommentBox, @CreateDate)";

        //            command.Parameters.AddWithValue("@UserNameEmailAddress", UserNameEmailAddress);
        //            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
        //            command.Parameters.AddWithValue("@CommentBox", CommentBox);
        //            command.Parameters.AddWithValue("@CreateDate", CreateDate);

        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //public async Task CreateReport()
        //{
        //    ReportModel model = new ReportModel(
        //    CreateDate = CreateDate,
        //    UserNameEmailAddress = UserNameEmailAddress,
        //    PhoneNumber = PhoneNumber,
        //    CommentBox = CommentBox);

        //    await _reportEndpoint.PostReport(CreateDate, UserNameEmailAddress, PhoneNumber, CommentBox);
        //    try
        //    {
        //        await _reportEndpoint.PostReport(model.CreateDate, model.UserNameEmailAddress, model.PhoneNumber, model.CommentBox);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }