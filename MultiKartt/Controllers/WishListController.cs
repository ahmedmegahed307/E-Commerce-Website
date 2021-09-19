using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using Microsoft.AspNetCore.Mvc;
using MultiKartt.BL;
using MultiKartt.InfraStructure;
using MultiKartt.Models;

namespace MultiKartt.Controllers
{
    public class WishListController : Controller
    {
       IProductService ProductInterface;
        MultiContext ctx;
        public WishListController(MultiContext context,IProductService qq)
        {
            ctx = context;
            ProductInterface = qq;
        }
        public IActionResult AddToWishList(int id)
        {
           
            WishListModel wishes = HttpContext.Session.GetObjectFromJson<WishListModel>("wishlist");
            if (wishes == null)
            {
                wishes = new WishListModel();


            }
            TbProduct product = ProductInterface.GetById(id);

            wishes.ListWish.Add(new WishListData()
            {
                WishListDataId = product.TbProductId,
                ProductName = product.ProductName,
                Image = product.ImageName,
                Price = product.PurchasePrice
            });



            HttpContext.Session.SetObjectAsJson("wishlist", wishes);

            return Redirect("/WishList/wishlist");
        }
        public IActionResult wishlist()
        {
            WishListModel wishes = HttpContext.Session.GetObjectFromJson<WishListModel>("wishlist")?? new WishListModel();

            return View(wishes);
        }
        public IActionResult RemoveItem(int id)
        {
            WishListModel oShopingCart = HttpContext.Session.GetObjectFromJson<WishListModel>("wishlist");
            oShopingCart.ListWish.Remove(oShopingCart.ListWish.Where(a => a.WishListDataId == id).FirstOrDefault());
            HttpContext.Session.SetObjectAsJson("wishlist", oShopingCart);
            return RedirectToAction("wishlist");
        }
    }
}
