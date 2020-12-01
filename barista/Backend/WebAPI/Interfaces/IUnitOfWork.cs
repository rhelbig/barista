using System.Threading.Tasks;
using WebAPI.Interfaces.Users;

namespace WebAPI.Interfaces
{
    public interface IUnitOfWork
    {
         IUserRepository UserRepository {get; }
         IDrinkRepository DrinkRepository {get; }
         Task<bool> SaveAsync();
    }
}