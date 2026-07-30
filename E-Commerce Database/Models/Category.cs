using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce_Database.Models
{

    public class Category
    {
        [Key]

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }



        // category M-1 Product
        public ICollection<Product> Products { get; set; }


    }
}
