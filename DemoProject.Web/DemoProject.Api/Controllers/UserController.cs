using AutoMapper;
using DemoProject.Api.Models;
using DemoProject.Data;
using DemoProject.Training.BusinessObjects;
using DemoProject.Training.Contexts;
using DemoProject.Training.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly IUserService _userService;
        //private readonly IMapper _mapper;
        //Try
        //protected DbContext _dbContext;

        //protected DbSet<Training.Entities.User> _dbSet;
        //public UserController(IUserService userService, DbContext context, IMapper mapper)
        //{
        //    //_userService = userService;
        //    _dbContext = context;
        //    _mapper = mapper;
        //    _dbSet = _dbContext.Set<Training.Entities.User>();
        //}
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var getUserModel = new GetUserModel();
            return getUserModel.GetUser(id);
            //return "value";
        }

        // POST api/<UserController>
        [HttpPost("AddUser")]
        public async Task<Object> SaveWord([FromBody] /*User user*/ AddUserModel model)
        {
            try
            {
                
                model.SaveWord();

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


        //[HttpPost("AddUser")]
        //public async Task<Object> SaveWord([FromBody] User user)
        //{
        //    try
        //    {
        //        _userService.SaveWord(user);
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }

        //}

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
