using MusicStore.Web.Models;
using MusicStore.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        //
        // GET: /ShoppingCart/
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Setup our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems=cart.GetCartItems(),
                CartTotal=cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }
	}
}