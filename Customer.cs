namespace RestaurantMVCApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Master.Customers")]
    public partial class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        public string Email { get; set; }   

    }
}
