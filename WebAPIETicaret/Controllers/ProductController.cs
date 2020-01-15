using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIETicaret.DesignPatterns.SingletonPattern;
using WebAPIETicaret.Models.Context;
using WebAPIETicaret.Models.Entities;
using WebAPIETicaret.Models.VMClasses;

namespace WebAPIETicaret.Controllers
{
    public class ProductController : ApiController
    {
        MyContext db;
        public ProductController()
        {
            db = DBTool.DBInstance;
        }

        //[HttpGet]
        public HttpResponseMessage GetProducts()
        {

            List<ProductVM> productVMList = new List<ProductVM>();

            foreach (ProductCategory item in db.ProductCategories.ToList())
            {
                ProductVM pvm = new ProductVM();
                pvm.CategoryName = item.Category.CategoryName;
                pvm.ProductName = item.Product.ProductName;
                pvm.FeatureName = item.Product.ProductFeatures.FirstOrDefault().Feature.FeatureName;
                pvm.Value = item.Product.ProductFeatures.FirstOrDefault().Value;
                pvm.ImagePath = item.Product.ImagePath;
                pvm.UnitPrice = item.Product.UnitPrice;
                productVMList.Add(pvm);

            }

            return Request.CreateResponse(HttpStatusCode.OK, productVMList);
        }


    }
}
