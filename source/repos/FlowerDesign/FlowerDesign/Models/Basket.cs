using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerDesign.Models
{
    public class Basket : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}