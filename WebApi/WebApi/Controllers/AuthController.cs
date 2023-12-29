using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class AuthController: ControllerBase
    {
      

        [HttpPost]
        [Route("api/[controller]/signup")]
        public IActionResult SignUp([FromBody] User user)
        {
            var id = 1;
            var registeredUser=new User();
            registeredUser.id = id;
            registeredUser.password = user.password;
            registeredUser.email= user.email;
            registeredUser.name = user.email;
            id++;
            UserRepository.AddUser(registeredUser);
            return Ok("ثیت نام شما با موفقیت انجام شد");
        }

        [HttpPost]
        [Route("api/[controller]/signin")]
        public IActionResult SignIn([FromBody] User user)
        {
            var signedUser = UserRepository.getUser(user.email,user.password);

            if (signedUser != null)
            {

                return Ok(signedUser);
            }
            if (signedUser == null)
            {
                return NotFound("کاربری با این مشخصات یافت نشد");
            }

            return BadRequest();

            

        }
    }
}
