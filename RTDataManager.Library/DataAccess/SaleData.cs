using RTDataManager.Library.Internal.DataAccess;
using RTDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDataManager.Library.DataAccess
{
    public class SaleData
    {
        public void SaveSale(SaleModel saleInfo, string cashierId)
        {
            // TODO- make this SOLID/Dry/Better 
            // start filling in the sale detail models we will save to the database
            
            List<SaleDetialDBModel> details = new List<SaleDetialDBModel>();
            ProductData products = new ProductData();
            var taxrate = ConfigHelper.GetTaxRate()/100;

            foreach (var item in saleInfo.SaleDetails)
            {
                var detail = new SaleDetialDBModel
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                //get the info about this product 
                var productInfo = products.GetProductById(detail.ProductId);

                if(productInfo == null)
                {
                    throw new Exception($"The product Id of { detail.ProductId } could not be found in the database.");
                }

                if (productInfo.IsTaxable)
                {
                    detail.Tax = (detail.PurchasePrice * taxrate);
                }

                detail.PurchasePrice = (productInfo.RetailPrice * detail.Quantity);

                details.Add(detail);
            }

            // create the sale model
            SaleDBModel sale = new SaleDBModel
            {
                Subtotal = details.Sum(x => x.PurchasePrice),
                Tax = details.Sum(x => x.Tax),
                CashierId = cashierId
            };

            sale.Total = sale.Subtotal + sale.Tax;


            // save the sale model
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData("dbo.spSale_Insert", sale, "REPORTSDATASQL");

            //Get the ID from the sale model
            sale.Id = sql.LoadData<int, dynamic>("spSale_LookUp", 
                new { CashierId = sale.CashierId, SaleDate = sale.SaleDate }, 
                "REPORTSDATASQL").FirstOrDefault();

            // finish filling in the sale detial models.
            foreach (var item in details)
            {
                item.SaleId = sale.Id;
                // save the sale detail models
                sql.SaveData("dbo.spSaleDetail_Insert", item, "REPORTSDATASQL");
            }

        }


        //public List<ProductModel> GetProduct()
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    var output = sql.LoadData<ProductModel, dynamic>("dbo.spProducts_GetAll", new { },
        //        "REPORTSDATASQL");

        //    return output;
        //}
    }
}
