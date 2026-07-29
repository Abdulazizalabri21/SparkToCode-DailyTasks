using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_Database.Models
{
    public class Review
    {
        [Key]

        public int ReviewId { get; set; }
        public int Ratings { get; set; }    
        public string Comment { get; set; }


        //Order 1-1 Review

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }


        // write Review << User M-1 Review
        [ForeignKey("User")]
        public int userID { get; set; }
        public User User { get; set; }


    }
}
