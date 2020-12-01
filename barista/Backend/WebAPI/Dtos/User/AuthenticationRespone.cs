using WebApi;
using WebAPI.Models;

namespace WebApi.Models
{
    public class AuthenticateResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(UserModel user, string token)
        {
            FirstName = user.UserFirstName;
            LastName = user.UserLastName;
            Username = user.UserName;
            Token = token;
        }
    }
}