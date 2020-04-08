using System;
using System.Collections.Generic;


namespace HungryNinja.Models
{
    public class Buffet
    {
        // public List<Food> Menu = new List<Food>();
        public List<Food> Menu;
    
     
    //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("SpicyRamen", 1000, true, false),
                new Food("KimChiFries", 800, true, false),
                new Food("NinjaProtienBar", 2000, false, true),
                new Food("SpicyFriedRice", 1500, false, true),
                new Food("StirFriedVegetables", 1500, false, false),
                new Food("SideOfGinger", 200, true, false),
                new Food("NinjaSandwhich", 1200, false, false),
                new Food("NinjaSmoothie", 1200, false, true),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            int RandNum = rand.Next(Menu.Count);
            var RandFood = Menu[RandNum];
            Console.WriteLine(RandFood.Name);
            return RandFood;
        }
    }
}