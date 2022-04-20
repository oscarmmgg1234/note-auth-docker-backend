using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using note_auth_backend.Data;
using note_auth_backend.Models;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace note_auth_backend.Controllers
{
    [Route("Api/[controller]")]
    public class AuthController : ControllerBase
    {

        IConfiguration _config;

        public AuthController(IConfiguration configuration)
        {
            _config = configuration;
        }
    //Login User
        [HttpGet, Route("Login/User")]
        public List<User> Login([FromBody] LoginRequestModel model)
        {
          

            using (var context = new AuthDBContext(_config))
            {
                var player = context.User.Where(x => x.Email == model.Email && x.Password == model.Password);
                

                if(player.Count() > 0)
                {
                    return player.ToList();
                }

                return null;
            }
        }

        //register users
        [HttpPost, Route("Register/User")]
        public IActionResult Register([FromBody] RegisterRequestModel model)
        {
            using (var context = new AuthDBContext(_config))
            {
                var newUser = new User();
                newUser.ID = Guid.NewGuid().ToString();
                newUser.Email = model.Email;
                newUser.Date_Joined = DateTime.Now;
                newUser.Password = model.Password;
                newUser.First_Name = model.First_Name;
                newUser.Last_Name = model.Last_Name;
                newUser.gender = model.gender;
                context.Add<User>(newUser);
                
                return Ok(context.SaveChanges());
            }
        }

       
    }
}
