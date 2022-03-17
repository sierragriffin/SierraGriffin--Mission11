//Purchase Controller

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineBookStore.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchaseRepository repo { get; set; }
        private Cart cart { get; set; }

        public PurchaseController(IPurchaseRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your basket is empty!");
            }

            if (ModelState.IsValid)
            {
                purchase.Lines = cart.Items.ToArray();
                repo.SavePurchase(purchase);
                cart.ClearCart();

                return RedirectToPage("/OrderConfirmation");
            }
            else
            {
                return View();
            }
        }
    }
}
