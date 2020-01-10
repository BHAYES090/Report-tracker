using System;
using System.Collections.Generic;
using System.Text;
using TRACKERLIBRARY.models;
using TRACKERLIBRARY.Models;

namespace TRACKERLIBRARY.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO - wire up the CreateReport for text files.
        /// <summary>
        /// saves a new report to a text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public INTERREPORTMODEL CreateInterReport(INTERREPORTMODEL model)
        {
            //model.Id = 1;

            return model;
        }
    }
}
