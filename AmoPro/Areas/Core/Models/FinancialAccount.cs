using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmoPro.Areas.Core.Models
{
    public abstract class  FinancialAccount
    {
        public long Id { get; set; }
        public string AccountNo { get; set; }
        public decimal Balance { get; set; }
        public decimal Limit { get; set; }
        public void Debit(decimal amount)
        {
           if(this.Balance > amount)
               Balance -= amount;
           else
               throw new Exception("Error:Insufficient balance");
        }

        public void Credit (decimal amount)
        {
            if (Balance + amount > this.Limit)
                Balance = +amount;
            else
                throw new Exception("Error: Account limit exceeded");
        }
    }

    public enum drcr {dr, cr};
   
}