using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIETicaret.Models.Entities
{
    public class ProductFeature:BaseEntity
    {
        public int ProductID { get; set; }
        public int FeatureID { get; set; }

        public string Value { get; set; }

        // relational properties

        public virtual Product Product { get; set; }

        public virtual Feature Feature { get; set; }

    }
}