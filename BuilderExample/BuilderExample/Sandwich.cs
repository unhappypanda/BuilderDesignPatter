using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderExample
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool isToasted { get; set; }
        public bool hasMayo { get; set; }
        public bool hasMustard { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("Bread type: {0}", BreadType);
            if (isToasted)
                Console.WriteLine("is toasted");
            if (hasMayo)
                Console.WriteLine("has mayo");
            if (hasMustard)
                Console.WriteLine("has mustard");
            Console.WriteLine("Cheese type: {0}", CheeseType);
            Console.WriteLine("Meat type: {0}", MeatType);
            Console.WriteLine("Vegetables:");
            foreach (string vegetable in Vegetables)
            {
                Console.WriteLine("{0}", vegetable);
            }
            Console.WriteLine("\n");
        }
    }

    public enum BreadType
    {
        Wheat,
        white
    }

    public enum CheeseType
    {
        Cheddar,
        Swiss
    }

    public enum MeatType
    {
        Salami,
        Turkey,
        Ham
    }
}
