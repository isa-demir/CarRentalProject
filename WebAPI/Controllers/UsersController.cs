using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAllUsers();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetbyId(int id)
        {
            var result = _userService.GetUserById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.AddUser(user);
            
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.UpdateUser(user);

            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.RemoveUser(user);

            return result.Success ? Ok(result) : BadRequest(result);
        }

    }
}
