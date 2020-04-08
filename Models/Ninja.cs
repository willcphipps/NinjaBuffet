using System;
using System.Collections.Generic;



namespace HungryNinja.Models
{
    public class Ninja
    {
        
        public string Name;
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja(string name)
        {
            FoodHistory = new List<Food>();
            calorieIntake = 0;
            Name = name;
        }
        public bool IsFull
            {
                get { 
                    if(calorieIntake > 10000){
                        return true;
                    }
                    else{
                    return false;
                }
                
                }
            }
        public void Eat(Food food)
        {

            if (IsFull == false)
            {
                calorieIntake += food.Calories;
                FoodHistory.Add(food);
                Console.WriteLine($"{Name}, you have eaten {food.Name} and is spicyness proved {food.IsSpicy}. Its sweetness was {food.IsSweet}");
                Console.WriteLine($"You have eaten {calorieIntake} so far");
            }
            else
            {
                throw new Exception("You are becomming too fat, Ninja. You cannot eat more.");
            }
        }

        // build out the Eat method
        // public void Eat(Food item)
        // {
        // }
    }
}