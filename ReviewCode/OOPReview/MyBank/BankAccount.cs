using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewCode.OOPReview.MyBank
{
   public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach(var allTrans in allTransaction)
                {
                    
                    balance += allTrans.Amount;
                }
                return balance;
            }
        }
        private static int accountNumber = 12345657;
        private List<Transaction> allTransaction = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Intial Balance");
            this.Number = accountNumber.ToString();
        }

        public  void MakeDeposit(decimal amount, DateTime date, string notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposited must be positive");
            }
            var deposit = new Transaction(amount, date, notes);
            allTransaction.Add(deposit);
        }
        public void MakeWithdraw(decimal amount, DateTime date, string notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Widthraw must be positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("No sufficint fond to withdraw");
            }
            var widthraw = new Transaction(-amount, date, notes);
            allTransaction.Add(widthraw);
        }
        public string GetTransactionHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\t\t\tAmount\t Notes");
            foreach(var item in allTransaction)
            {
                report.AppendLine($"{item.Date}\t\t{item.Amount}\t\t{item.Notes}");
            }
            return report.ToString();
        }
        
        
    }
}
