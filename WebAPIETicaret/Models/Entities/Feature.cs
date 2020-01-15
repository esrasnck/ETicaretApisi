using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIETicaret.Models.Entities
{
    public class Feature:BaseEntity
    {
        public string FeatureName { get; set; }
        public string Description { get; set; }

        // relational properties

        public virtual List<ProductFeature> ProductFeatures { get; set; }
    }
}