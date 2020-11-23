using System;
using System.Linq;
using System.Web;

namespace FlowerDesign.Models
{
    public class OrderProduct : EntityBase
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}