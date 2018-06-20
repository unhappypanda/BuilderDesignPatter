using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich sandwitch1 = new Sandwich();

            sandwitch1.BreadType = BreadType.Wheat;
            sandwitch1.CheeseType = CheeseType.Cheddar;
            sandwitch1.MeatType = MeatType.Ham;
            sandwitch1.hasMayo = true;
            sandwitch1.isToasted = true;
            sandwitch1.hasMustard = true;
            sandwitch1.Vegetables = new List<string>{ "Tomato", "Onion" };
            
            sandwitch1.Display();


            Sandwich sandwitch2 = new Sandwich();

            sandwitch2.BreadType = BreadType.Wheat;
            sandwitch2.CheeseType = CheeseType.Cheddar;
            sandwitch2.MeatType = MeatType.Turkey;
            sandwitch2.hasMayo = true;
            sandwitch2.isToasted = true;
            sandwitch2.hasMustard = true;
            sandwitch2.Vegetables = new List<string> { "Tomato", "Onion" };
            
            sandwitch2.Display();

            Console.ReadKey();

        }
    }
}
