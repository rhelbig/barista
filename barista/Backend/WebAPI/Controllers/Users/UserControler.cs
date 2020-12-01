using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApi.Models;
using WebAPI.Dtos.User;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers.Users
{
    [Route("api/auth")]
    [ApiController]
    public class UserLoginControler : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public UserLoginControler(IUnitOfWork uow, IMapper mapper){
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpPut, Route("register")]
        public  async Task<IActionResult>AddNewUser(RegisterUserDto registerUserDto)
        {
            var user = mapper.Map<UserModel>(registerUserDto);
            user.LastUpdatedBy = 1;
            user.LastUpdatedOn = DateTime.Now;
             try{
                uow.UserRepository.AddUser(user);
                await uow.SaveAsync();
            } catch(DbUpdateException e) {
                if(e.InnerException.Message.Contains("duplicate key")){
                    return BadRequest("Either a username or password has already been used.");
                }else {
                    throw e;
                }
            }
            
            return StatusCode(201);
        }

        [HttpPost, Route("login")]
        public AuthenticateResponse Login(UserLoginDto user){
            UserModel userFromDb = uow.UserRepository.getUserByName(user.UserName);
            if(user == null || userFromDb == null){
                return null;
            }
            if(user.UserName == userFromDb.UserName && user.UserPassword == userFromDb.UserPassword) {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretAwesomeness"));
                var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "https://localhost:5000",
                    audience: "https://localhost:5000",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signingCredentials
                );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return new AuthenticateResponse(userFromDb, tokenString);
            }
            return null;
        }
        
    }
}