using DataManager1.Models;
using Microsoft.AspNet.Identity;
using RTDataManager.Library.DataAccess;
using RTDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataManager1.Controllers
{
    //[Authorize]
    public class SaleController : ApiController
    {
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData();
            string userId = RequestContext.Principal.Identity.GetUserId();

            data.SaveSale(sale, userId);
            
        }
    }
}
