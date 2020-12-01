using Microsoft.AspNetCore.Mvc;
using WebAPI.Dtos.User;

namespace WebAPI.Interfaces.Users
{
    public interface IUserAuth
    {
         public IActionResult Login(UserLoginDto userLoginDto);
    }
}