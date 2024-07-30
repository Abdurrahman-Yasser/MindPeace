using System.ComponentModel.DataAnnotations;

namespace BlazorIdentityV2.Data.Models
{
    public class RInputModel : InputModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
