using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
namespace MultiKartt.Models
{
    public class DetailsViewModel : ReviewsModel
    {
        public TbProduct TbProduct { get; set; }
        public List<TbProduct> ListAllProducts { get; set; }
        public List<TbProduct> ListRelatedProducts { get; set; }
        public List<TbProduct> ListRelatedProducts2 { get; set; }

    }
}
