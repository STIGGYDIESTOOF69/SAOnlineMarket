using System.ComponentModel.DataAnnotations;

namespace SAOnlineMarket.Models
{
    public class Admin
    {
        [Required]
        public int AdminId { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public int AdmimEmail { get; set; }
        [Required]
        public string AdminPassword { get; set; }

    }
}
