﻿namespace TheVendingMachine
{
    public class Item2 : IProduct
    {
        string description = "Description";
        int price = 1;
        readonly string use = "Use";

        public Item2(string newDescription, int newPrice, string newUse)
        {
            description = newDescription;
            price = newPrice;
            use = newUse;
        }
        public string Description { get { return description; } }
        public int Price { get { return price; } }
        public string Use { get { return use; } }

        public string Examine()
        {
            return $"Button 2:\n {description}\n The price is {price}kr";
        }

    }
}
