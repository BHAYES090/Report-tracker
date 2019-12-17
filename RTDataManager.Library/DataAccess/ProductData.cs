using RTDataManager.Library.Internal.DataAccess;
using RTDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProduct()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProducts_GetAll", new { }, "REPORTSDATASQL");

            return output;
        }

        public ProductModel GetProductById(int ProductId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProducts_GetById", new { Id = ProductId }, "REPORTSDATASQL").FirstOrDefault();

            return output;
        }
    }
}
