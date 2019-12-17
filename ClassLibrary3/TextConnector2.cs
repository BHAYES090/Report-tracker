using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3.TextHelpers;

namespace TrackerLibrary2
{
    
    public class TextConnector2 : IDataConnection2
    {
        private const string InterReportsFile = "InterReportModel2.csv";
        private const string UsersFile = "UsersModel.csv";
        private const string ReportFile = "ReportModel.csv";

        public USERMODEL2 CreateUserAccount(USERMODEL2 model)
        {
            List<USERMODEL2> userModels2 = UsersFile.FullFilePath().LoadFile().ConvertToUserModel();

            int currentId = 1;
            if (userModels2.Count > 0)
            {
                currentId = userModels2.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            userModels2.Add(model);

            userModels2.SaveToUserFile(UsersFile);

            return model;
        }
        
        
        
        //TODO - wire up the CreateReport for text files.
        public INTERREPORTMODEL2 CreateInterReport(INTERREPORTMODEL2 model)
        {
            // * load text file 
            // * convert text to List<INTERREPORTMODEL2>
            List<INTERREPORTMODEL2> INTERREPORTMODELS2 = InterReportsFile.FullFilePath().LoadFile().ConvertToInterReportModels2();


            //  find the max ID 
            int currentId = 1;
            if (INTERREPORTMODELS2.Count > 0)
            {
                currentId = INTERREPORTMODELS2.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // add the new record with the new ID (max + 1)
            INTERREPORTMODELS2.Add(model);
            
           
            //Convert the prizes to List<String>
            //save the List<string> to the text file
            INTERREPORTMODELS2.SaveToInterReportFile(InterReportsFile);

            return model;
        }

        public REPORTMODEL2 CreateReport(REPORTMODEL2 model)
        {
            List<REPORTMODEL2> REPORTMODELS2 = ReportFile.FullFilePath().LoadFile().ConvertToReportModel();

            int currentId = 1;
            if (REPORTMODELS2.Count > 0)
            {
                currentId = REPORTMODELS2.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            
            REPORTMODELS2.Add(model);
 
            REPORTMODELS2.SaveToReportFile(InterReportsFile);

            return model;
        }
    }
}
