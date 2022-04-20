using System;
using System.ComponentModel.DataAnnotations;
namespace note_auth_backend.Models
{
    public class RegisterRequestModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [Required]
        public bool gender { get; set; }

    }
}
