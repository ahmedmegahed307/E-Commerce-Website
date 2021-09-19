using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiKartt.Models;
using Domains;
using MultiKartt.BL;
using MultiKartt.InfraStructure;

namespace MultiKartt.Controllers
{
    public class ContactController : Controller
    {
       IProductService ProductInterface;
        MultiContext ctx;
   
        public ContactController(MultiContext context,IProductService c)
        {
            ProductInterface = c;
            ctx = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SuccessMessage()
        {
            //ModelContact1 model = HttpContext.Session.GetObjectFromJson<ModelContact1>("Index");

            //return View(model);
            return View();
        }

        [HttpPost]
        public IActionResult Save(ModelContact1 model)
        {
            ViewBag.name = model.FirstName;
            ctx.ContactUs.Add(model);
            ctx.SaveChanges();
            // model = HttpContext.Session.GetObjectFromJson<ModelContact1>("Index"); must be static data
            return View("SuccessMessage");
           
        }
    }
}
