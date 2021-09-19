using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MultiKartt.BL;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Domains;
using MultiKartt.InfraStructure;
using MultiKartt.Models;

namespace MultiKartt.Controllers
{
    public class DetailsController : Controller
    {
       IProductService ProductInterface;
        public DetailsController(IProductService service)
        {
            ProductInterface = service;

        }
        public IActionResult Details(int id)
        {
            DetailsViewModel model = new DetailsViewModel();
            model.ListAllProducts = ProductInterface.GetAll();
            model.TbProduct = ProductInterface.ProductWithImage(id);
          //  model.ListRelatedProducts = ProductInterface.GetRelatedProduct(model.TbProduct.SalesPrice).Take(6).ToList();
            model.ListRelatedProducts2 = ProductInterface.Related(model.TbProduct.SalesPrice).ToList();
            return View(model);
        }

    }
    }
