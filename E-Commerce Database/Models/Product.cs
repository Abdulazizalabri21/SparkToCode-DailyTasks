using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text;

namespace E_Commerce_Database.Models
{

    public class Product
    {

        [Key]

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        //   OrderProduct M-1 Product

        public ICollection<Order_Product> O { get; set; }

        // category 1-M Product

        [ForeignKey("C")]
        public int CategoryId { get; set; }
        public Category C { get; set; }

    }
}
