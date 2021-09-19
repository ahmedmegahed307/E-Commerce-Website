using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domains
{
   public class TbSlider
    {
        [Key]
        public int TbSliderId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(200)]
        public string ImageName { get; set; }

    }
}
