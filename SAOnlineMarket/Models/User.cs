using System.ComponentModel.DataAnnotations;

namespace SAOnlineMarket.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int UserEmail { get; set; }
        [Required]
        public string UserPassword { get; set; }


    }
}
