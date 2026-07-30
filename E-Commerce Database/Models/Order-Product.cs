using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Database.Models
{

    [PrimaryKey(nameof(OrderId),nameof(ProductId))] // assigning the two FK as Primary Key as Component
    public class Order_Product
    {
        // Order 1-M OrderProduct M-1 Product --> as three tables 

        //  Order 1-M OrderProduct

        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public Order Orders { get; set; }


        //   OrderProduct M-1 Product

        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product Products { get; set; }

        public int Quantity { get; set; } // Quantity attribut in the relationship
    }
}
