using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce_Database.Models
{
    public class Users
    {
        [Key]
        public int userID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // placing Ordder
       public  ICollection <Order> Orders { get; set; }

        // write Review >> User 1-M Review

        public ICollection <Review> Reviews { get; set; }


    }
}
