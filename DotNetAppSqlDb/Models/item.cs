using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class Item
    {
        public string itemId  { get; set; }
        public string description { get; set; }
        public string status_Id { get; set; }
        public DateTime date { get; set; }
        public string IpAddress { get; set; }
    }
}