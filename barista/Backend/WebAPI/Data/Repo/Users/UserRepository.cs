using System.Linq;
using WebAPI.Interfaces.Users;
using WebAPI.Models;

namespace WebAPI.Data.Repo.Users
{
    public class UserRepository : IUserRepository
    {
        DataContext dc;
        public UserRepository(DataContext dc){
            this.dc = dc;
        }

        public void AddUser(UserModel userModel)
        {
            dc.UserModels.AddAsync(userModel);
        }

        public UserModel getUserByName(string userName)
        {
            UserModel ret = dc.UserModels.FirstOrDefault(a => a.UserName == userName);
            return ret;
        }
    }
}