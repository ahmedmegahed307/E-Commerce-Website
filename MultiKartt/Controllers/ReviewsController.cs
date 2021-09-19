using Domains;
using MultiKartt.BL;
using MultiKartt.InfraStructure;
using MultiKartt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiKartt.Controllers
{
    public class ReviewsController : Controller
    {
        MultiContext ctx;
        IProductService IProduct;
        public ReviewsController(MultiContext context, IProductService x)
        {
            ctx = context;
            IProduct = x;
        }
        public IActionResult Reviews()
        {
            return View(ctx.TbReviews.ToList());
        }
        [HttpPost]
        public IActionResult ReviewsInfo(ReviewsModel model)
        {
            ViewBag.first = model.FirstName;
            ctx.TbReviews.Add(model);
            ctx.SaveChanges();
            return View("SuccessMessage");
        }
        public IActionResult SuccessMessage()
        {
            return View();
        }
        public IActionResult ReviewsMainPage()
        {
            return View();
        }
    }
}
