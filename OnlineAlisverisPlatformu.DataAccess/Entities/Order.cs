using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAlisverisPlatformu.DataAccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

       
        public int CustomerId { get; set; }
        public User Customer { get; set; }

        
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
