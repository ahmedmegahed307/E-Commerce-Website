using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MultiKartt.InfraStructure
{
    public class MultiContext : DbContext
    {
        
        public MultiContext(DbContextOptions<MultiContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TbProduct> TbProduct { get; set; }
        public virtual DbSet<TbCategory> TbCategory { get; set; }
        public virtual DbSet<TbProductImages> TbProductImages { get; set; }
        public virtual DbSet<TbProductDiscount> TbProductDiscount { get; set; }
        public virtual DbSet<ApiView> ApiView { get; set; }
        public virtual DbSet<TbSlider> TbSlider { get; set; }
        public virtual DbSet<ModelContact1> ContactUs{ get; set; }
        public virtual DbSet<ShopingCart> personaldata1 { get; set; }
        public virtual DbSet<TbBanner> TbBanner { get; set; }
        public virtual DbSet<ReviewsModel> TbReviews { get; set; }
        // protected override void OnModelCreating(ModelBuilder builder)//for identity
        //  {
        //   base.OnModelCreating(builder);
        //  }
    }
}
