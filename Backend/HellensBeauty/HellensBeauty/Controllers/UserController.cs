using Microsoft.AspNetCore.Mvc;
using HellensBeauty.Service;
using HellensBeauty.entity;
namespace HellensBeauty.Controllers
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
