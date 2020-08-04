using System;

namespace hungry_ninja.models
{
    public class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet;
        // add a constructor that takes in all 
        //four parameters: Name, Calories, IsSpicy, IsSweet

        public Food(string name, int cal, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
        
    }
}