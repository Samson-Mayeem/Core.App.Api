using System.Security.Claims;

namespace Core.App.Api.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? Email { get; set; }
        public string? SurName{get; set;}
        public string? FirstName{get; set;}
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
