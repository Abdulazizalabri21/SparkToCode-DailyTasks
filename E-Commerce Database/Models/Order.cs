using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Text;

namespace E_Commerce_Database.Models
{
   

    public class Order
    {
        [Key]

        public int  OrderId { get; set; }
        public DateTime OrderDate { get; set; } 
        public string TotalAmount { get; set; }


        //placing Order 1 - M
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public Users Users { get; set; }



        // Order 1-M productOrder M-1 product 
        public ICollection<Order_Product> P { get; set; }


        //Order 1-1 Review

        public Review Reviews { get; set; }


    }
}
