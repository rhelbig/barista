using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Drinks;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/drink")]
    [ApiController]
    public class DrinkController : ControllerBase {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public DrinkController(IUnitOfWork uow, IMapper mapper) {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpPut, Route("add")]
        public  async Task<IActionResult>AddNewDrink(DrinkDto drinkDto)
        {
            var drink = mapper.Map<DrinkModel>(drinkDto);
            drink.LastUpdatedBy = 1;
            drink.LastUpdatedOn = DateTime.Now;
            uow.DrinkRepository.AddDrink(drink);
            await uow.SaveAsync();
            
            
            return StatusCode(201);
        }

        [HttpGet("{id}")]
        public DrinkModel GetDrinkAsync(Guid id)
        {
            return uow.DrinkRepository.GetDrink(id);
        }

        [HttpGet]
        public  async Task<IActionResult> GetDrinks()
        {
           var drinks = await uow.DrinkRepository.GetDrinksAsync();
           return Ok(drinks);
        }
        
    }
}