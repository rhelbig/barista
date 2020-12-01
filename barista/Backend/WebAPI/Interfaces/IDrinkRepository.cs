using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IDrinkRepository
    {
        Task<IEnumerable<DrinkModel>> GetDrinksAsync();
        void AddDrink(DrinkModel drink);
        void DeleteDrink(int DrinkId);
        DrinkModel GetDrink(Guid id);
    }
}