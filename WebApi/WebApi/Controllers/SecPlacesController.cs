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
            return new
            {
                title= " جاذبه های گردشگری در آذربایجان شرقی",
                description= " آذربایجان شرقی، یکی از جذاب‌ترین استان‌های نیمه شمال غرب ایران است. تاریخ غنی و مردم مهمان‌نواز، با ویژگی‌‌های فرهنگی خاص این دیار، بر جذابیت‌های این استان زیبا افزوده است. اگر قصد سر زدن به استان آذربایجان شرقی دارید، باید لیست بلندبالایی از مراکز دیدنی تهیه کنید..",
                images= imagePlaces
            };
        }

    }
}
