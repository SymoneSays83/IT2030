using System;
using System.ComponentModel.DataAnnotations;

namespace Project_3.Models
{
    public class CalculateModel
    {
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter a subtotal greater than zero.")]
        public decimal? Subtotal { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage ="Please enter a percent between 0 and 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount()
        {
            decimal? discount = Subtotal * (DiscountPercent / 100);
            return discount;
        }
    }
}
