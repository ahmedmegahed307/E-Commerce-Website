using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiKartt.Models;
using MultiKartt.BL;
using Domains;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MultiKartt.InfraStructure;

namespace MultiKartt.Controllers
{
    public class HomeController : Controller
    {
        MultiContext ctx;
       IProductService ProductInterface;
        public HomeController(MultiContext context,IProductService service)
        {
            ctx = context;
            ProductInterface = service;
        }
        public IActionResult Index()
        {
            HomePageViewModel model = new HomePageViewModel();
            model.ListSlider = ProductInterface._slider().ToList();
            model.ListBanner = ProductInterface.BannerImages().ToList();
            model.ListAllProducts = ProductInterface.GetAll();
            model.ListNewProducts = model.ListAllProducts.Take(8).ToList();
            model.ListCategory = model.ListAllProducts.GroupBy(a => a.CategoryId).Select(a => a.First()).ToList();
            model.ListFeaturedProducts = model.ListAllProducts.Skip(8).Take(8).ToList();
            model.ListBestSeller = model.ListAllProducts.Skip(16).Take(8).ToList();


            return View(model);

        }
        public IActionResult test()
        {
            HomePageViewModel model = new HomePageViewModel();
            model.ListAllProducts = ProductInterface.GetAll();
            model.ListNewProducts = model.ListAllProducts.Take(8).ToList();
            model.ListCategory = model.ListAllProducts.GroupBy(a => a.CategoryId).Select(a => a.First()).ToList();
            model.ListFeaturedProducts = model.ListAllProducts.Skip(8).Take(8).ToList();
            model.ListBestSeller = model.ListAllProducts.Skip(16).Take(8).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult SetLanguage(string culture,string returnUrl)
        {
            Response.Cookies.Append
                (
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires=DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }

        public async Task<IActionResult> ProductsByCategory(string categorySlug, int page = 1)
        {
            TbCategory category = await ctx.TbCategory.Where(x => x.Slug == categorySlug).FirstOrDefaultAsync();
            if (category == null) return RedirectToAction("Index");

            int pageSize = 8;
            var products = ctx.TbProduct.Where(x => x.CategoryId == category.TbCategoryId).Skip((page - 1) * pageSize).Take(pageSize);

            ViewBag.PageNumber = page;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)ctx.TbProduct.Where(x => x.CategoryId == category.TbCategoryId).Count() / pageSize);
            ViewBag.CategoryName = category.CategoryName;
            ViewBag.CategorySlug = categorySlug;
            return View(await products.ToListAsync());
        }
        public IActionResult All()
        {

            return View();
        }
    }
}
