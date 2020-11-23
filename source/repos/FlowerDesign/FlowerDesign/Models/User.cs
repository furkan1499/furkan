using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowerDesign.Models
{
    public class User : EntityBase
    {
        public string Surname { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public virtual IEnumerable<UserAddress> UserAddress { get; set; }
    }
}