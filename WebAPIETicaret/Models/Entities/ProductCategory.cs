using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIETicaret.Models.Entities
{
    public class ProductCategory:BaseEntity
    {
        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        //Relational Properties

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }
    }
}