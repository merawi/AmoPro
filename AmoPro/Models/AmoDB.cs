using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AmoPro.Areas.Core.Models;

namespace AmoPro.Models
{
    public class AmoDB:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

    }
}