using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDemoNew.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public bool IsActive { get; set; } = true;
    }
}