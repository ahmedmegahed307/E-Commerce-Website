using System;
using System.Collections.Generic;
using System.Text;

namespace Domains
{
   public class TbCategory
    {

        public int TbCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int MyProperty { get; set; }
        public virtual ICollection<TbProduct> TbProduct { get; set; }
        public string Slug { get; set; }
    }
}
