using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIETicaret.Models.Context;
using WebAPIETicaret.Models.Entities;

namespace WebAPIETicaret.DesignPatterns.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        { 
            Random rnd = new Random();  
            for (int i = 0; i < 5; i++)
            {
                Category c = new Category();

                c.CategoryName = new Commerce("tr").Categories(1)[0];
                c.Description = new Lorem("tr").Sentence(100);
                context.Categories.Add(c);
                context.SaveChanges();
                for (int j = 0; j < 10; j++)
                {
                    Product p = new Product();

                    p.ProductName = new Commerce("tr").ProductName();
                    p.UnitPrice = Convert.ToDecimal(new Commerce("tr").Price());
                    p.UnitsInStock = rnd.Next(5, 500);
                    p.ImagePath = new Images().City();


                    context.Products.Add(p);
                    context.SaveChanges();


                    ProductCategory pc = new ProductCategory();
                    pc.ProductID = p.ID;
                    pc.CategoryID = c.ID;
                    context.ProductCategories.Add(pc);
                    context.SaveChanges();


                    if (i == 4)
                    {
                        ProductCategory pc2 = new ProductCategory();
                        pc2.ProductID = p.ID;
                        pc2.CategoryID = c.ID - 1;
                        context.ProductCategories.Add(pc2);
                    }
                    context.SaveChanges();

                    for (int k = 0; k < 20; k++)
                    {
                        Feature f = new Feature();
                        f.FeatureName = new Commerce("tr").ProductMaterial();
                        f.Description = new Lorem("tr").Sentence(4);
                        context.Features.Add(f);
                        context.SaveChanges();

                        ProductFeature pf = new ProductFeature();
                        pf.ProductID = p.ID;
                        pf.FeatureID = f.ID;
                        pf.Value = new Commerce("tr").Color();
                        context.ProductFeatures.Add(pf);
                        context.SaveChanges();
                    }



                }

            }      

        }
    }
}