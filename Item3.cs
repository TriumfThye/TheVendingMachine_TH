namespace TheVendingMachine
{
    public class Item3 : IProduct
    {
        string description = "Description";
        int price = 1;
        readonly string use = "Use";

        public Item3(string newDescription, int newPrice, string newUse)
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
            return $"Button 3:\n {description}\n The price is {price}kr";
        }

    }
}
