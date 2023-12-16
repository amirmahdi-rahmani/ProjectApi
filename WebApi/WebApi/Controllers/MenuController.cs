using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
       
      [HttpGet]
      public object[] GetMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            menuItems[0] = new MenuItem { id = 1, title = "خانه", link = "/" };
            menuItems[1] = new MenuItem { id = 3, title = "غذاها", link = "/foods" };
            menuItems[2] = new MenuItem { id = 4, title = "مشاهیر", link = "/famous" };
            menuItems[3] = new MenuItem { id = 5, title = "مکان های گردشگری", link = "/places" };
            menuItems[4] = new MenuItem { id = 6, title = "ورود / عضویت", link = "/auth/singIn" };

            return menuItems;
        }
     
    }
}
