using System;
namespace note_auth_backend.Data
{
    public class User
    {
        public string ID { get; set; }

        public string Email { get; set; }

        public string Password { get; set;}

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public DateTime Date_Joined { get; set; }

        public bool gender { get; set; }

        
    }
}
