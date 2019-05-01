using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaPickUp.Models;

namespace PizzaPickUp.Controllers
{
    public class OrderPizzaController : Controller
    {
        // GET: OrderPizza
        public ActionResult Pizza()
        {
            Order cheesePizza = new Order()
            {
                itemName = "Cheese Pizza",
                itemPrice = "8.75",
                description = "A cheesy pizza made with 5 different cheeses",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/cheese-pizza-800x800.png"
            };

            Order pPizza = new Order()
            {
                itemName = "Pepperoni Pizza",
                itemPrice = "10.00",
                description = "A spicy pizza topped with lots of pepperoni",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/pepperoni%20pizza-800x800.png"
            };

            Order vPizza = new Order()
            {
                itemName = "Veggie Pizza",
                itemPrice = "7.95",
                description = "Pizza loaded with lots of veggies",
                itemImg = @"https://i.dlpng.com/static/png/281526_thumb.png"
            };

            Order meatPizza = new Order()
            {
                itemName = "Meat Lovers Pizza",
                itemPrice = "13.99",
                description = "A spicy pizza topped with lots of pepperoni",
                itemImg = @"http://www.hammockpizza.co/image/cache/pizza/meatlover-pizza-800x800.png"
            };

            Order wings = new Order()
            {
                itemName = "Wings",
                itemPrice = "14.75",
                description = "Spicy wings with carrots and celery on the side",
                itemImg = @"https://www.pngkey.com/png/full/250-2505544_spice-up-your-menu-and-stretch-your-food.png"
            };

            Order carbonara = new Order()
            {
                itemName = "Carbonara Pasta",
                itemPrice = "14.75",
                description = "Fettuccine noods with carbonara pasta sauce, shrimp and cherry tomatoes",
                itemImg = @"https://toppng.com/public/uploads/preview/pasta-2-11550712027pkrt0kdmlk.png"
            };




            List<Order> od = new List<Order>();
            od.Add(cheesePizza);
            od.Add(pPizza);
            od.Add(vPizza);
            od.Add(meatPizza);
            od.Add(wings);
            od.Add(carbonara);

            return View(od);

        }
    }
}