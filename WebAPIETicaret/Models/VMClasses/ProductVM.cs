using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIETicaret.Models.Context;
using WebAPIETicaret.Models.Entities;

namespace WebAPIETicaret.Models.VMClasses
{
    public class ProductVM
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public string CategoryName { get; set; }
        public string FeatureName { get; set; }
        public string Value { get; set; }

    }
}