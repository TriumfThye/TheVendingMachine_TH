using System;
using System.Collections.Generic;

namespace TheVendingMachine
{
    public class VendingMachine
    {
        List<IProduct> allItems = new List<IProduct>();
        int oldMoney = 0;

        public VendingMachine()//Add new products
        {
            allItems.Add(new Item1("Snickers from Mars Inc.", 15, "chocolate bar"));//products
            allItems.Add(new Item2("Turkish Peber from Fazer", 22, "liquorice drops"));
            allItems.Add(new Item3("Skittles from Wrigley Company", 28, "confectionery"));
            allItems.Add(new Item4("Gumdrop from Various", 32, "American hard gums"));
        }
        int moneyPool;
        int[] denomination = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public void MoneyTransfer(int inputMoney)
        {
            oldMoney = moneyPool;
            foreach (var item in denomination)
            {
                if (inputMoney == item)
                {
                    moneyPool = inputMoney + moneyPool;
                    break;
                }
            }
            if (inputMoney + oldMoney != moneyPool)
            {
                throw new ArgumentException("You can only use one coin or note at a time");
            }
        }

        public int ShowMoneyPool()
        {
            return moneyPool;
        }

        public string[] ShowAllItems()
        {
            string[] allItemDescription = new string[allItems.Count];
            int count = -1;
            foreach (var item in allItems)
            {
                count++;
                allItemDescription[count] = item.Examine();
            }
            return allItemDescription;
        }

        public IProduct Purchase(int button)
        {
            if (button < 1 || button > allItems.Count)
            {
                throw new ArgumentException("This button doesn't exist");
            }
            int number = button - 1;
            IProduct item = allItems[number];
            if (moneyPool >= item.Price) 
            {
                moneyPool = moneyPool - item.Price;
                Console.WriteLine("Enjoy your "+ item.Use);
            }
            else if (moneyPool < item.Price)
            {
                throw new ArgumentException("Money Pool is too small");
            }
            return item;
        }

        public int ChangeBack()
        {
            int change = moneyPool;
            moneyPool = 0;
            return change;
        }
    }
}
