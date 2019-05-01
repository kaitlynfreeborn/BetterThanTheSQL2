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

            Menu wings = new Menu()
            {
                itemName = "Wings",
                itemPrice = "14.75",
                description = "Spicy wings with carrots and celery on the side",
                itemImg = @"https://banner2.kisspng.com/20180703/awa/kisspng-wild-wing-buffalo-wing-food-meatball-vegetarian-cu-wild-wing-cafe-5b3b77a4e2ca59.2834952515306239089289.jpg"
            };



            List<Menu> mn = new List<Menu>();
            mn.Add(cheesePizza);
            mn.Add(pPizza);
            mn.Add(meatPizza);
            mn.Add(wings);

            return View(mn);
        }
    }
}