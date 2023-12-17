using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class SecPlacesController : ControllerBase
    {
        private List<secPimage> imagePlaces = new List<secPimage>()
    {
            new secPimage
            {
             image = System.IO.File.ReadAllBytes("Images/Ala.jpg"),
            },
            new secPimage {image = System.IO.File.ReadAllBytes("Images/Arasbaran.jpg")},
             new secPimage {image = System.IO.File.ReadAllBytes("Images/kelisa.jpg")},
              new secPimage {image = System.IO.File.ReadAllBytes("Images/kan1.jpg")}
    };



        [HttpGet]
        public object GetPlaces()
        {
            return imagePlaces;
        }

    }
}
