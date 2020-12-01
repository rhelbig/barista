using System.Threading.Tasks;
using WebAPI.Data.Repo;
using WebAPI.Data.Repo.Users;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Users;

namespace WebAPI.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;
        public UnitOfWork(DataContext dc){
            this.dc = dc;
        }
        public IUserRepository UserRepository =>
            new UserRepository(dc);
        public IDrinkRepository DrinkRepository =>
            new DrinkRepository(dc);

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
}