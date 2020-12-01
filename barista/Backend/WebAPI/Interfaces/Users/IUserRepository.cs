using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces.Users
{
    public interface IUserRepository
    {
         void AddUser(UserModel userModel);
         UserModel getUserByName(string userName);
    }
}