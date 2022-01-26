using DAW2.Data;
using DAW2.Models;
using DAW2.Models.DTOs;
using DAW2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        /*
        public UserController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        */

        /*
        [HttpGet("getUsers")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _databaseContext.DataBaseModels.ToListAsync());
        }
        */

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserRequestDTO user)
        {
            var response = _userService.Authenticate(user);

            if (response==null)
            {
                return BadRequest(new { Message = "Username or Password is invalid" });
            }

            return Ok(response);
        }

        //POST
        //create user

        /*
        [HttpPost("createUser")]
        public IActionResult Create(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password),
                Role = Role.User
            };
            _userService.CreateUser(userToCreate);
        return Ok();
        } */

         
        [HttpPost("createUser")]
        public IActionResult Create(User user)
        {
            _userService.CreateUser(user);
            return Ok();
        } 
        //create admin

        [HttpPost("createAdmin")]
        public IActionResult CreateAdmin(UserRequestDTO user)
        {
            var userToCreate = new User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.Password),
                Role = Role.Admin
            };
            return Ok();
        }

        //GET
        //get All Users

        [Authorize(Roles ="Admin")]
        [HttpGet("getAllUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }


        //PUT
        [HttpPut("UpdateUser")]
        public IActionResult Update(User user)
        {
            _userService.UpdateUser(user);
            return Ok();
        }

        //DELETE
        [HttpDelete("DeleteUser")]
        public IActionResult Delete(User user)
        {
            _userService.DeleteUser(user);
            return Ok();
        }

    }
}
