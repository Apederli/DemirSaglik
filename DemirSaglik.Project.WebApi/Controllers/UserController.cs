using DemirSaglik.Project.Business.Abstract;
using DemirSaglik.Project.Entities;
using DemirSaglik.Project.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemirSaglik.Project.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login([FromBody] UserDTO userDTO)
        {

            if (!string.IsNullOrEmpty(userDTO.Name) && !string.IsNullOrEmpty(userDTO.Password))
            {

                User user = new User
                {
                    Name = userDTO.Name,

                    Password = userDTO.Password
                };

                var userConnection = _userService.Login(user);


                if (userConnection == true)
                {
                    return Ok();
                }

            }
            return BadRequest();
        }
    }
}
