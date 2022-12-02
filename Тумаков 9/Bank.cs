using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Тумаков_9
{
    class Bank
    {

        public enum AccountType
        {
            Расчетный, Накопительный, Кредитный
        }

        Queue<BankTransaction> queue = new Queue<BankTransaction>();
        public int accountNumber;
        public AccountType accountType;
        public int balance;
        static List<int> accountNumbers = new List<int>();
        public Bank()
        {
            GetAccountNumber();
        }
        public Bank(AccountType accountType)
        {
            this.accountType = accountType;
            GetAccountNumber();
        }
        public Bank(int balance)
        {
            this.balance = balance;
            GetAccountNumber();
        }

        public void GetAccountNumber()
        {
            Random rnd = new Random();
            int num = rnd.Next(10000000, 100000000);
            while (accountNumbers.Contains(num))
            {
                num = rnd.Next(10000000, 100000000);
            }
            accountNumber = num;
        }
        public void MoneyTransfer(Bank otherbank, int money)
        {
            otherbank.balance -= money;
            balance += money;
            queue.Enqueue(new BankTransaction());
        }
        public void Dispose()
        {
            string path = "note1.txt";
            BankTransaction text = queue.Peek();

            // полная перезапись файла 
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLineAsync($"time: {text.time.Hour}:{text.time.Minute} Date: {text.date.Date}");
            }
        }
    }
}
