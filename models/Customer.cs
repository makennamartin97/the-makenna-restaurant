using System;
using System.Collections.Generic;

namespace hungry_ninja.models
{
    public class Customer
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Customer() {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        
        // add a public "getter" property called "IsFull"
        public bool IsFull {
            get {
                return calorieIntake > 1200;

            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            calorieIntake = calorieIntake - 10;
            if (IsFull == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Calorie intake: {calorieIntake}. You have eaten past the limit and can't eat anymore!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*****Thank you for coming*****");
            }else{
                Console.ForegroundColor = ConsoleColor.Green;
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"You have eaten: {item.Name} - Spicy? {item.IsSpicy}, Sweet? {item.IsSweet}, Calories: {item.Calories}");
            }
        }
    }
}