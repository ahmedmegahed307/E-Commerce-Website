using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using Microsoft.AspNetCore.Http;

namespace MultiKartt.Models
{
    public class HomePageViewModel 
    {

        public  IEnumerable<TbSlider> ListSlider { get; set; }
        public IEnumerable<TbBanner> ListBanner { get; set; }
        public IEnumerable<TbProduct> ListAllProducts { get; set; }
        public IEnumerable<TbProduct> ListNewProducts { get; set; }
        public IEnumerable<TbProduct> ListFeaturedProducts { get; set; }
        public IEnumerable<TbProduct> ListBestSeller { get; set; }
        public IEnumerable<TbProduct> ListCategory { get; set; }
       
        
      
     // public IQueryable<TbProduct> products { get; set; } test
        public TbProduct product { get; set; } //test

    }
}
