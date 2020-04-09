using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    abstract class Ninja
    {
        public string Name;
        protected int calorieIntake;    
        public List<IConsumable> ConsumptionHistory;
        public Ninja(string name)
        {
            Name = name;
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull { get;set; }
        // {
        //     get { 
        //         if(calorieIntake > 10000){
        //             return true;
        //         }
        //         else{
        //         return false;
        //     }

        //     }
        //     set { IsFull = value;  }
        // }
        public abstract void Consume(IConsumable item);
    }
}




// {
//     public class Ninja
//     {
        
//         public string Name;
//         private int calorieIntake;
//         public List<Food> FoodHistory;
//         public Ninja(string name)
//         {
//             FoodHistory = new List<Food>();
//             calorieIntake = 0;
//             Name = name;
//         }
//         public bool IsFull
//             {
//                 get { 
//                     if(calorieIntake > 10000){
//                         return true;
//                     }
//                     else{
//                     return false;
//                 }
                
//                 }
//             }
//         public void Eat(Food food)

//     }
// }