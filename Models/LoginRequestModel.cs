using System;
using System.ComponentModel.DataAnnotations;
namespace note_auth_backend.Models
{
    public class LoginRequestModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
