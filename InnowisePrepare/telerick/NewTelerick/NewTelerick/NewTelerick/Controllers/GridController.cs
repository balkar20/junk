using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using NewTelerick.Models;
using Kendo.Mvc.Extensions;

namespace NewTelerick.Controllers
{
    public class GridController : Controller
    {
        public static List<ProductViewModel> dbProducts = Enumerable.Range(1, 50).Select(i => new ProductViewModel
        {
            ProductID = i,
            Price = i * 10,
            Discontinued = i % 7 ==0? true:false,
            UnitsInStock = i * 2,
            ProductName = "ProductName " + i
        }).ToList();

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            var dsResult = dbProducts.ToDataSourceResult(request);
            return Json(dsResult);
        }

        public ActionResult Products_Create([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            product.ProductID = dbProducts.Count + 1;
            dbProducts.Add(product);
            return Json(new object[] { product }.ToDataSourceResult(request));
        }

        public ActionResult Products_Destroy([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            var productToDelete = dbProducts.Find(o=> o.ProductID == product.ProductID);
            for (int i = 0; i < dbProducts.Count; i++)
            {
                if (dbProducts[i].ProductID == product.ProductID)
                {
                    dbProducts.Remove(dbProducts[i]);
                    break;
                }
            }
            return Json(new object[] { product }.ToDataSourceResult(request));
        }

        public ActionResult Products_Update([DataSourceRequest] DataSourceRequest request, ProductViewModel product)
        {
            var productToUpdate = dbProducts.Find(o => o.ProductID == product.ProductID);
            for (int i = 0; i < dbProducts.Count; i++)
            {
                if (dbProducts[i].ProductID == product.ProductID) {
                    dbProducts[i] = product;
                    break;
                }
            }
            return Json(new object[] { product }.ToDataSourceResult(request));
        }
    }
}
