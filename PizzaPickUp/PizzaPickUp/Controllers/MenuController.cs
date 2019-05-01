using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaPickUp.Models;

namespace PizzaPickUp.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            Menu cheesePizza = new Menu()
            {
                itemName = "Cheese Pizza",
                itemPrice = "8.75",
                description = "A cheesy pizza made with 5 different cheeses",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/cheese-pizza-800x800.png"
            };

            List<Menu> mn = new List<Menu>();
            mn.Add(cheesePizza);

            return View(mn);
        }
    }
}