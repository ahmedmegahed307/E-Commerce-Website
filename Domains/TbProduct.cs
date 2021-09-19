using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domains
{
   public class TbProduct
    {
        [Key]
        public int TbProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal SalesPrice { get; set; }
        [Required]  
        public decimal PurchasePrice { get; set; }
        public int CategoryId { get; set; }
        public string ImageName { get; set; }
        public DateTime CreationDate { get;set;}
        public virtual TbCategory Category { get; set; }
        public virtual ICollection<TbProductImages> TbProductImages  { get; set; }
    }
}
