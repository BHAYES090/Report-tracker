using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TextConnector1 : IDataConnection1
    {
        //TODO - wire up the CreateReport for text files.
        /// <summary>
        /// saves a new report to a text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public INTERREPORTMODEL1 CreateInterReport(INTERREPORTMODEL1 model)
        {
            model.id = 1;

            return model;
        }
    }
}
