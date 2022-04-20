using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace note_auth_backend.Data
{
    public class AuthDBContext : DbContext
    {
        IConfiguration _config;
        public AuthDBContext(IConfiguration configuration)
        {
            _config = configuration;
        }
        
        public DbSet<User> User { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(_config.GetConnectionString("DB"), new MySqlServerVersion(new Version("8.0")));
            }
        }
    }
}
