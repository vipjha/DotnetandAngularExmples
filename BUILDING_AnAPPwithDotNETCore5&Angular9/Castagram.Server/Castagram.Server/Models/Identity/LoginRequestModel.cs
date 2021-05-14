using System.ComponentModel.DataAnnotations;

namespace Castagram.Server.Models.Identity
{
    public class LoginRequestModel
    {
        [Required]
        public string UserName { get; set; }

        
        [Required]
        public string Password { get; set; }
    }
}
