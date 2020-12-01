using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Data.Repo
{
    public class DrinkRepository : IDrinkRepository
    {
        DataContext dc;
        public DrinkRepository(DataContext dc){
            this.dc = dc;
        }
        
        public void AddDrink(DrinkModel drink){
            dc.DrinkModels.AddAsync(drink);
        }

        public void DeleteDrink(int DrinkId)
        {
            var drink = dc.DrinkModels.Find(DrinkId);
            dc.DrinkModels.Remove(drink);
        }

        public DrinkModel GetDrink(Guid id)
        {
            return dc.DrinkModels.Find(id);
        }

        public async Task<IEnumerable<DrinkModel>> GetDrinksAsync()
        {
            return await dc.DrinkModels.ToListAsync();
        }
    }
}