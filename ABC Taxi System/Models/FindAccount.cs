using System.ComponentModel.DataAnnotations;

namespace ABC_Taxi_System.Models
{
    /// <summary>
    /// Model for Find Account
    /// </summary>
    public class FindAccount
    {
        [Required]
        [Display(Name = "Username or Email")]
        public string UsernameOrEmail { get; set; }
    }
}