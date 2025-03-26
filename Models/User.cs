using System.ComponentModel.DataAnnotations;

namespace ERPSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
