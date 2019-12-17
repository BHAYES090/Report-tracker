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
    [Authorize]
    public class ProductController : ApiController
    {
        public List<ProductModel> Get()
       
        {
            ProductData data= new ProductData();

            return data.GetProduct();
        }
    }
}
