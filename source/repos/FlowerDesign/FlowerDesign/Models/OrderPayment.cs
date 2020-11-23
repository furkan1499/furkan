using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerDesign.Models
{
    public class OrderPayment : EntityBase
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public OrderType OrderType { get; set; }
        public decimal Price { get; set; }
        public string Bank { get; set; }
    }
    public enum OrderType
    {
        Havale = 0,
        Kredikarti = 1
    }
}