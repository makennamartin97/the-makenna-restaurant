using System;
using System.Collections.Generic;

namespace hungry_ninja.models
{
    public class Buffet
    {
        public List<Food> Menu;
     
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Spaghetti and Meatballs", 420, false, false),
                new Food("Mushroom Swiss Burger", 615, false, false),
                new Food("Thai Curry", 330, true, false),
                new Food("Award-Winning Chili", 460, true, false),
                new Food("Marshmallow Fudge Sundae", 530, false, true),
                new Food("Mango Habanero Chicken Wings", 320, true, false),
                new Food("Raspberry Truffle Cannolis", 220, false, true),
                new Food("Steamed Classic King Crab Legs", 410, true, false),
                new Food("Mango Chili Lime Rotisserie Chicken", 400, false, true),
                new Food("Chicken Caesar Salad", 280, false, true),
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }

    }
}