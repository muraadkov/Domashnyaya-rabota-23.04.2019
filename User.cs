using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork_23._04._2019
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DoublePassword { get; set; }
        public string MobileNumber { get; set; }
        public virtual ShoppingBasket ShoppingBasket { get; set; }
    }
}
