using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary2;

namespace ClassLibrary3.TextHelpers
{
    //  * load text file 
    //  * convert text to List<INTERREPORTMODEL2>
    //  find the max ID 
    // add the new record with the new ID (max + 1)
    //Convert the prizes to List<String>
    //save the List<string> to the text file
    
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) 
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<INTERREPORTMODEL2> ConvertToInterReportModels2(this List<string> lines)
        {
            List<INTERREPORTMODEL2> output = new List<INTERREPORTMODEL2>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                INTERREPORTMODEL2 R = new INTERREPORTMODEL2();
                R.Id = int.Parse(cols[0]);
                R.UserName = cols[1];
                R.EmailAddress = cols[2];
                R.PhoneNumber = cols[3];
                R.CommentBox = cols[4];
                R.CreateDate = DateTime.Parse(cols[5]);
                //R.ScreenShot = s(cols[6]);
                output.Add(R);
            }
            return output;
        }

        public static List<USERMODEL2> ConvertToUserModel(this List<string> lines)
        {
            List<USERMODEL2> output = new List<USERMODEL2>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                USERMODEL2 u = new USERMODEL2();
                u.Id = int.Parse(cols[0]);
                u.FirstName = cols[1];
                u.LastName = cols[2];
                u.UserName = cols[3];
                u.EmailAddress = cols[4];
                u.PhoneNumber = cols[5];
                output.Add(u);
            }
            return output;
        }

        public static List<REPORTMODEL2> ConvertToReportModel(this List<string> lines)
        {
            List<REPORTMODEL2> output = new List<REPORTMODEL2>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                REPORTMODEL2 f = new REPORTMODEL2();
                f.id = int.Parse(cols[0]);
                f.ReportName = cols[1];
                f.ReportID = cols[2];
                f.Severity = cols[3];
                f.ReportStatus = cols[4];
                f.Comments = cols[5];
                f.Details = cols[6];
                f.BugBehavior = cols[7];
                f.Solutions = cols[8];
                f.FirstReported = DateTime.Parse(cols[9]);
                f.FirstREPORTER = cols[10];
                output.Add(f);
            }
            return output;
        }
        public static void SaveToInterReportFile(this List<INTERREPORTMODEL2> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (INTERREPORTMODEL2 R in models)
            {
                lines.Add($"{ R.Id },{ R.UserName },{ R.EmailAddress },{ R.PhoneNumber },{ R.CommentBox },{ R.CreateDate }, { R.ScreenShot }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToUserFile(this List<USERMODEL2> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (USERMODEL2 u in models)
            {
                lines.Add($"{ u.Id },{ u.FirstName },{ u.LastName},{ u.UserName },{ u.EmailAddress },{ u.PhoneNumber }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        
        
        public static void SaveToReportFile(this List<REPORTMODEL2> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (REPORTMODEL2 f in models)
            {
                lines.Add($"{ f.id },{ f.ReportName },{ f.ReportID},{ f.Severity },{ f.ReportStatus },{ f.Comments },{ f.Details },{ f.BugBehavior },{ f.Solutions},{ f.FirstReported},{ f.FirstREPORTER}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}

