using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmoPro.Areas.Core.Models;
using AmoPro.Models;

namespace AmoPro.Areas.Core.Models
{
    public class BankAccount : Account
    {
        public string BankNo { get; set;}
        public Customer Owner { get; set; }
    }
}