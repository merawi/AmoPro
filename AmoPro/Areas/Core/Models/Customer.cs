using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmoPro.Areas.Core.Models;

namespace AmoPro.Areas.Core.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public Wallet CWallet { get; set;}
        public IEnumerable<BankAccount> CBankAccounts { get; set; }
    }
}