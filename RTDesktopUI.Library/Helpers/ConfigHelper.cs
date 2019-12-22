﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        // TODO move this from config to API
        public decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool IsValidTaxRate = Decimal.TryParse(rateText, out decimal output);

            if (IsValidTaxRate == false)
            {
                throw new ConfigurationErrorsException("The tax rate is not set up properly");
            }

            return output;
        }
    }
}