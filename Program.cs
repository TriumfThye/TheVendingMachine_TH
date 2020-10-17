using System;

namespace TheVendingMachine
{   /*  Assignment 4, Vending Machine. Ulf Bengtsson, Lexicon Växjö.
        Thye Hansen, triumfthye@hotmail.com
        2020-10-15 
    */
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            bool runChoise = true;
            while (runChoise)
            {
                Console.Write("Examine items - press E\nDeposit money - press D\nPurchase item - press P\nFinish - press F\n ");
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "E":
                        string[] items = vendingMachine.ShowAllItems();
                        foreach (var item in items)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "D":
                        try
                        {
                            Console.Write("Deposit money ");
                            int inputMon = int.Parse(Console.ReadLine());
                            vendingMachine.MoneyTransfer(inputMon);
                            Console.WriteLine("Money Pool: " + vendingMachine.ShowMoneyPool());
                        }
                        catch (ArgumentException AE)
                        {
                            Console.WriteLine(AE.Message);
                            Console.WriteLine("Money Pool: " + vendingMachine.ShowMoneyPool());
                        }
                        break;
                    case "P":
                        try
                        {
                            Console.Write("Purchase item: ");
                            int button = int.Parse(Console.ReadLine());
                            IProduct Purchase = vendingMachine.Purchase(button);
                            Console.WriteLine("Money Pool: " + vendingMachine.ShowMoneyPool());
                        }
                        catch(ArgumentException AE)
                        {
                            Console.WriteLine(AE.Message);
                            Console.WriteLine("Money Pool: " + vendingMachine.ShowMoneyPool());

                        }
                        break;
                    case "F":
                        Console.WriteLine("Remember your change: " + vendingMachine.ChangeBack());
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You can only choose \"E\", \"D\", \"P\" or \"F\" ");
                        break;
                }
            }

        }
    }
}
