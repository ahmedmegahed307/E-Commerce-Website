using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domains
{
    public class ApiView

    {
        [Key]
        public int TbProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageName { get; set; }
        public int TbCategoryId { get; set; }
        public decimal PurchasePrice { get; set; }
        public string CategoryName { get; set; }
    }
}
