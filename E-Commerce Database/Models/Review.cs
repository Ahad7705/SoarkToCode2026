using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Database.Models
{
    public class Review
    {
    
       
            public int ReviewId { get; set; }

            public int Rating { get; set; }

            public string Comment { get; set; }


            // Order 1 : 1 Review

            [ForeignKey("Order")]
            public int OrderId { get; set; }

            public Order Order { get; set; }
        }
    }


