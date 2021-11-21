using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website1.Models
{
    public class CartModel
    {
        public int Quantity { get; set; }
        public products Product { get; set; }
        public string Size { get; set; }
    }
}