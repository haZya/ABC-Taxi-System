using System;
using System.ComponentModel.DataAnnotations;

namespace ABC_Taxi_System.Models
{
    /// <summary>
    /// Model for driver daily revenue
    /// </summary>
    public class DriverDailyRev
    {
        public DateTime Date { get; set; }

        [Display(Name = "Revenue for the day")]
        public decimal Amount { get; set; }
    }
}