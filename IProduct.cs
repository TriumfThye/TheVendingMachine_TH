namespace TheVendingMachine
{
    public interface IProduct
    {
        public string Description { get; }
        public int Price { get; }
        public string Use { get; }
        public string Examine();
    }

}
