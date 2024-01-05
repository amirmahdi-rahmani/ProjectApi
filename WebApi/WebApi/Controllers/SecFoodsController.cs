using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class SecFoodsController : ControllerBase
    {
      
        [HttpGet]
        public object GetFoods()
        {
            return new
            {
                title = " غذا های استان آذربایجان شرقی",
                description = " آذربایجان شرقی، یکی از جذاب‌ترین استان‌های نیمه شمال غرب ایران است. تاریخ غنی و مردم مهمان‌نواز، با ویژگی‌‌های فرهنگی خاص این دیار، بر جذابیت‌های این استان زیبا افزوده است. اگر قصد سر زدن به استان آذربایجان شرقی دارید، باید لیست بلندبالایی از مراکز دیدنی تهیه کنید." ,
                image = System.IO.File.ReadAllBytes("Images/dolma2.jpg")

            };
        }

    }
}
