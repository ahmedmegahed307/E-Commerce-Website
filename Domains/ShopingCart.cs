
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class ShopingCart 
    {
        public ShopingCart()
        {
            ListItems = new List<ShopingCartItem>();
        }
        public List<ShopingCartItem> ListItems { get; set; }
        public decimal Total { get; set; }


        [Key]
        public int id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public double phonenumber { get; set; }

        public string country { get; set; }

        public string emailaddress { get; set; }
        public string address { get; set; }

        public int postalcode { get; set; }
    }
}
