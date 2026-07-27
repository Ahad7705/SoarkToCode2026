using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Database.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }


        // Category 1 : M Product

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }


        // Product M : M Order

        public List<OrderProduct> OrderProducts { get; set; }
    
}
}
