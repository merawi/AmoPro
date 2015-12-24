using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmoPro.Areas.Monitoring.Models
{
    public class Logger
    {
        public DateTime TimeStamp {get;set;}
        public string LogEntry { get; set; }
    }
}