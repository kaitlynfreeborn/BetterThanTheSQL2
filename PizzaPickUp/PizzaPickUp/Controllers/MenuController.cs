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

            Menu pPizza = new Menu()
            {
                itemName = "Pepperoni Pizza",
                itemPrice = "10.00",
                description = "A spicy pizza topped with lots of pepperoni",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/pepperoni%20pizza-800x800.png"
            };

            Menu meatPizza = new Menu()
            {
                itemName = "Meat Lovers Pizza",
                itemPrice = "13.99",
                description = "A spicy pizza topped with lots of pepperoni",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/meatlover-pizza-800x800.png"
            };


            List<Menu> mn = new List<Menu>();
            mn.Add(cheesePizza);
            mn.Add(pPizza);
            mn.Add(meatPizza);

            return View(mn);
        }
    }
}