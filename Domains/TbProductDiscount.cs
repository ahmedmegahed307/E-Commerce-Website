using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domains
{
   public class TbProductDiscount
    {
        [Key]
        public int TbProductDiscountId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal DiscountPercent { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public virtual TbProduct Product { get; set; }
    }
}
