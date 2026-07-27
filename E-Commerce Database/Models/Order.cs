using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Database.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }


        // User 1 : M Order

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }


        // Order M : M Product

        public List<OrderProduct> OrderProducts { get; set; }


        // Order 1 : 1 Review

        public Review Review { get; set; }
    }
}

