using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmoPro.Areas.Core.Models
{
    public class Wallet : FinancialAccount
    {
        public Customer customer;
    }
}