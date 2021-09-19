using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domains
{
   public class TbBanner
    {
        [Key]
        public int TbBannerId { get; set; }
        [Required]
        public string BannerTitle { get; set; }
        [Required]
        public string ImageName { get; set; }
        [Required]
       public string BannerName { get; set; }


    }
}
