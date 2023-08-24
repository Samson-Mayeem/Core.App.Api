using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Core.App.Api.Data
{
    public class JwtAuthManager
    {
        private readonly string _apiAuthKey;
        private readonly JwtAuthManager _jwtAuthManager;   
        private readonly IDictionary<string, string> _authUserKeys = new Dictionary<string, string>()
        {
            {"test","password"},
            {"test1","pwd"}
        };
        public JwtAuthManager(string Key)
        {
            _apiAuthKey = Key;
        }  
        /*public string Authenticate(string email, string password) 
        {
            if(!users.Any(u->u.Key))
            {

            }
         }*/
    }
}

