﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaPickUp.Models
{
    public class BulidOwn
    {
        public string Size { get; set; }
        public string Topping { get; set; }
        public string CrustOption { get; set; }
        public string Sauce { get; set; }
    }

    public Size Get()
    {
        return new Size() { size = "Small (Serves 1-2)" };
        return new Size() { size = "Medium (Serves 2-3)" };
        return new Size() { size = "Large (Serves 3-4)" };
    }

    public Topping Get()
    {
        return new Size() { topping = "Meats (Anchovies, Bacon, Canadian Bacon, Cup & Curl Pepperoni, Genoa Salami, Grilled Chicken, Hamburger, Italian Sausage, Meatballs, Pepperoni, Polish Sausage, Sausage)" };
        return new Size() { topping = "Cheeses (Blue Cheese, Cheddar, Feta, Mozzarella, Parmesan, Provolone)" };
        return new Size() { topping = "Veggies (Artichoke Hearts, Banana Peppers, Basil, Black Olives, Green Bell Pepper, Green Olives, Jalapeño Peppers, Kalamata Olives, Mushrooms, Red Bell Pepper, Red Onion, Roasted Garlic, Roma Tomato, Spinach, Sun-Dried Tomato)" };
        return new Size() { topping = "Fruits (Mandarin Orange, Pineapple)" };
        return new Size() { topping = "Other (Balsamic Glaze, Parmesan-Herb Shake)" };
    }

    public CrustOption Get()
    {
        return new CrustOption() { crust = "Thin Crust" };
        return new CrustOption() { crust = "Hand - Tossed" };
        return new CrustOption() { crust = "Gluten - Free" };
    }

    public Sauce Get()
    {
        return new Sauce() { sauce = "Red sauce" };
        return new Sauce() { sauce = "BBQ" };
        return new Sauce() { sauce = "Alfredo" };
        return new Sauce() { sauce = "Olive oil and garlic glaze" };
        return new Sauce() { sauce = "Pesto(Nut Free)" };
    }
}