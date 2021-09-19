using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiKartt.BL;
using MultiKartt.InfraStructure;
using MultiKartt.Models;

namespace MultiKartt.Controllers
{
    public class ShoppingCart : Controller
    {
        MultiContext ctx;
       IProductService ProductInterface;
        public ShoppingCart(MultiContext context,IProductService qq)
        {
            ctx = context;
            ProductInterface = qq;
        }
        public IActionResult AddToCart(int id)
        {
            ShopingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShopingCart>("Cart");
            if (oShopingCart == null)//if I opened for the first time
                oShopingCart = new ShopingCart();
            TbProduct item = ProductInterface.GetById(id);
            ShopingCartItem shopingItem = oShopingCart.ListItems.Where(a => a.ItemId == id).FirstOrDefault();
            if (shopingItem != null)
            {
                shopingItem.Qty++;
                shopingItem.Total = shopingItem.Price * shopingItem.Qty;
            }
            else
            {
                oShopingCart.ListItems.Add(new ShopingCartItem()
                {
                    ItemId = item.TbProductId,
                    ItemName = item.ProductName,
                    ImageName = item.ImageName,
                    Price = item.SalesPrice,
                    Qty = 1,
                    Total = item.SalesPrice
                });
            }

            oShopingCart.Total = oShopingCart.ListItems.Sum(a => a.Total);
            HttpContext.Session.SetObjectAsJson("Cart", oShopingCart);
            if (HttpContext.Request.Headers["X-Requested-With"] != "XMLHttpRequest")
                return Redirect("/ShoppingCart/Cart");

            return Redirect("/ShoppingCart/Cart");
        }

        public IActionResult Cart()
        {
            ShopingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShopingCart>("Cart")?? new ShopingCart();

            return View(oShopingCart);
        }

       
        public IActionResult RemoveItem(int id)
        {
            ShopingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShopingCart>("Cart");
            oShopingCart.ListItems.Remove(oShopingCart.ListItems.Where(a => a.ItemId == id).FirstOrDefault());
            oShopingCart.Total = oShopingCart.ListItems.Sum(a => a.Total);
            HttpContext.Session.SetObjectAsJson("Cart", oShopingCart);
            return RedirectToAction("Cart");
        }
        public IActionResult CheckOut()
        {
            ShopingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShopingCart>("Cart");
            if (oShopingCart == null)
            {
                return View("emptycart");
            }
            else
                return View(oShopingCart);
        }
        [HttpPost]
        public IActionResult SaveInfo(ShopingCart model)
        {
            
            ctx.personaldata1.Add(model);
            ctx.SaveChanges();
            ViewBag.first = model.firstname;
            ViewBag.last = model.lastname;
            ViewBag.phone = model.phonenumber;
            ViewBag.email = model.emailaddress;
            ViewBag.country = model.country;
            ViewBag.address = model.address;
            ViewBag.postcode = model.postalcode;
            model = HttpContext.Session.GetObjectFromJson<ShopingCart>("Cart");//yoruldum vallah

            return View("OrderSuccess",model);

        }
        public IActionResult OrderSuccess()
        {
            // ShopingCart oShopingCart = HttpContext.Session.GetObjectFromJson<ShopingCart>("CheckOut");
           
            return View();
        }
        public IActionResult Clear()
        {
            HttpContext.Session.Remove("Cart");
            return Redirect(Request.Headers["Referer"].ToString());
            //return RedirectToAction("Cart");

            //return RedirectToAction("Home","Index") or Redirect("/Home/Index"); go to another method in another controller

        }
    }
}
