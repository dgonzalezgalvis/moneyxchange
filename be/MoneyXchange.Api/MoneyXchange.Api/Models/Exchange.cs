using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyXchange.Api.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public string currency { get; set; }
        public float factor { get; set; }
    }
}