using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIETicaret.Models.Entities
{
    public class Category:BaseEntity
    {

        public string CategoryName { get; set; }
        public string Description { get; set; }



        // relational properties

        public virtual List<ProductCategory> ProductCategories { get; set; }


    }
}