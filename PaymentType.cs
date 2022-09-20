namespace RestaurantMVCApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Master.PaymentTypes")]
    public partial class PaymentType
    {
        public int PaymentTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentTypeName { get; set; }
    }
}
