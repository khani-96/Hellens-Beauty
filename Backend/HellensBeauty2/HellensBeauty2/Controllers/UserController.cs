using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HellensBeauty2.Entity;
using HellensBeauty2.Services;
namespace HellensBeauty2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService userService;

        [HttpPost]
        public void Create(UserEntity user)
        {

            userService = new UserService();
            userService.Create(user);

        }
        [HttpGet]
        public UserEntity Read(int id)
        {
            userService = new UserService();
            return userService.Read(id);
        }

        [HttpPut]
        public void Update(int id)
        {
            userService = new UserService();
            userService.Update(id);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            userService = new UserService();
            userService.Delete(id);

        }
    }
}
