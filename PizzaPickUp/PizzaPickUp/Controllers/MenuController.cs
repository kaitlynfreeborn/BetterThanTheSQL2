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

            Menu vPizza = new Menu()
            {
                itemName = "Veggie Pizza",
                itemPrice = "7.95",
                description = "Pizza loaded with lots of veggies",
                itemImg = @"https://i.dlpng.com/static/png/281526_thumb.png"
            };

            Menu meatPizza = new Menu()
            {
                itemName = "Meat Lovers Pizza",
                itemPrice = "13.99",
                description = "A spicy pizza topped with lots of pepperoni",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/meatlover-pizza-800x800.png"
            };

            Menu wings = new Menu()
            {
                itemName = "Wings",
                itemPrice = "14.75",
                description = "Spicy wings with carrots and celery on the side",
                itemImg = @"https://www.pngkey.com/png/full/250-2505544_spice-up-your-menu-and-stretch-your-food.png"
            };

            Menu carbonara = new Menu()
            {
                itemName = "Carbonara Pasta",
                itemPrice = "14.75",
                description = "Fettuccine noods with carbonara pasta sauce, shrimp and cherry tomatoes",
                itemImg = @"https://toppng.com/public/uploads/preview/pasta-2-11550712027pkrt0kdmlk.png"
            };

        


            List<Menu> mn = new List<Menu>();
            mn.Add(cheesePizza);
            mn.Add(pPizza);
            mn.Add(vPizza);
            mn.Add(meatPizza);
            mn.Add(wings);
            mn.Add(carbonara);

            return View(mn);
        }
    }
}