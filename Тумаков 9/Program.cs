using System;

namespace Тумаков_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков 1");
            Console.WriteLine();
            Bank bank = new Bank(1000);
            Console.WriteLine(bank.accountNumber);
            Console.WriteLine(bank.balance);

            Console.ReadKey();
            Console.WriteLine("Тумаков 2");
            Console.WriteLine();

            Console.ReadKey();
            Console.WriteLine("Тумаков 3");
            Console.WriteLine();
            Bank otherBank = new Bank(10000);
            bank.MoneyTransfer(otherBank, 10);
            bank.Dispose();


        }
    }
}
