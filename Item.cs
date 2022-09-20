namespace RestaurantMVCApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Master.Items")]
    public partial class Item
    {
        public int ItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }
    }
}
