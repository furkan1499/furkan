using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowerDesign.Models
{
    public class UserAddress : EntityBase
    {
        public int UserId { get; set; }
        public  User User { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

    }
}