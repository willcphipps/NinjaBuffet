using System;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of the Ninja Buffet!");
            Ninja naruto = new Ninja("Naruto");
            Buffet NinjaBuffet = new Buffet();
            Food food = NinjaBuffet.Serve();
            Food newfood = NinjaBuffet.Serve();
            naruto.Eat(food);
            naruto.Eat(food);
            naruto.Eat(food);
            naruto.Eat(food);
            naruto.Eat(food);
            naruto.Eat(food);
            naruto.Eat(newfood);
            naruto.Eat(newfood);

        }
    }
}
