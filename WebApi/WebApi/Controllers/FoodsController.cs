﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class FoodsController : ControllerBase
    {
        private List<item> foods = new List<item>()
    {
            new item {
                id=1,
                name= "کوفته تبریزی",
                description="کوفته تبریزی (به ترکی آذربایجانی: تبریز کوفته‌سی) یکی از خوراک‌های مشهور ایران است که شهرت جهانی دارد و منتسب به شهر تبریز است. انواع کوفته در نقاط مختلف خاورمیانه تهیه می‌شود و نقطه تمایز کوفته تبریزی بیشتر در طرز تهیه و مواد استفاده شده در آن است. در این خوراک از انواع سبزی‌های معطر استفاده می‌شود و به‌طور سنتی گوشت این کوفته در یک هاون سنگی و با دسته هاونی چوبی، کوبیده شده و رفته رفته سبزی‌ها و لپه به آن اضافه می‌گردد. امروزه اغلب برای آسان‌تر کردن روند کار به‌جای کوبیدن گوشت در هاون، آن را چندین بار چرخ می‌کنند. در آخر تخم‌مرغ آب‌پز، گردو و آلو خشک و آلبالو یا آلبالو خشک را داخل آن گذاشته و با مخلوطی از پیازداغ، سبزی مخصوص و زرشک تزئین می‌گردد. در آب این خوراک از رب گوجه فرنگی و زعفران به عنوان چاشنی استفاده می‌شود.",
                ImageOne=System.IO.File.ReadAllBytes("Images/kofte.jpg"),
                ImageTwo=System.IO.File.ReadAllBytes("Images/kofte2.jpg"),
                link="https://chishi.ir/287-koufte-tabrizi/",
},
            new item {
                id=2,
                name="آش ماست",
                description="آش ماست یکی از خوشمزه‌ترین آش‌های تبریز است که از پیاز، عدس، برنج، سبزی آش، آب گوشت، سیب‌زمینی، ماست، نخود، لوبیا، کلم برگ و هویج تهیه می‌شود. البته اگر به همین آش کمی رشته بزنید، تبدیل به آش کشک می‌شود که آن را به جای ماست، کشک می‌خورند.",
                ImageOne=System.IO.File.ReadAllBytes("Images/ashmas.jpg"),
                ImageTwo=System.IO.File.ReadAllBytes("Images/ashmas2.jpg"),
                link="https://chishi.ir/735-ash-mast/",
},
            new item {
                id=3,
                name="دلمه برگ مو",
                description="دلمه برگ مو یکی از انواع غذاهای بسیار خوشمزه و معروف خاورمیانه است که در کشورمان ایران هم از محبوبیت بالایی برخوردار است. این غذای خوشمزه از ترکیب برنج به همراه گوشت، حبوبات و سبزیجات تهیه می شود و در برگ های درخت انگور پیچیده می شود.",
                ImageOne=System.IO.File.ReadAllBytes("Images/dolma.jpg"),
                ImageTwo=System.IO.File.ReadAllBytes("Images/dolma1.jpg"),
                link="https://chishi.ir/339-dolme-barge-mo/",
},
            new item {
                id=4,
                name="خورش هویج",
                description ="خورش هویج یکی از غذاهای بسیار پرطرفدار میان تبریزی‌ها است، اما شاید هر کسی طعم آن را دوست نداشته باشد. برای تهیه‌ی این خورش، هویج‌ها را کبریتی خرد می‌کنند و با کمی روغن سرخ کرده و به آن نمک می‌افزایند. سپس مرغ یا گوشت را با آب، پیاز تفت‌‌داده شده و رب گوجه‌فرنگی می‌پزند یا سرخ می‌کنند و برای دادن عطر و طعمی بهتر، هم به گوشت و هم به هویج‌ها زعفران اضافه می‌کنند. در نهایت آلو را به مرغ یا گوشت خود اضافه کرده و می‌گذارند تا کامل بپزد. در پایان آب لیمو ترش را به هویج اضافه می‌کنند تا طعم شیرین نداشته باشد.",
                ImageOne=System.IO.File.ReadAllBytes("Images/havij.jpg"),
                ImageTwo=System.IO.File.ReadAllBytes("Images/havij2.jpg"),
                link="https://chishi.ir/1175-khoresh-havij/",
},
            new item {
                id=5,
                name="کوکوی لوبیا سبز",
                description="کوکوی لوبیا سبز یکی از قدیمی‌ترین کوکوهایی است که مردم تبریز اکثرا در مهمانی‌ها و مراسم افطاری ماه رمضان طبخ می‌کنند. به عنوان یک تبریزی به شما پیشنهاد می‌کنم که یا خودتان این کوکوی خوشمزه را بپزید، یا مهمان یک خانواده‌ی تبریزی شوید تا طعم بی‌نظیر آن را بچشید. برای تهیه‌ی این کوکو به لوبیا سبز، گوشت چرخ کرده، سیب زمینی، هویج، پیاز، تخم مرغ و زعفران نیاز دارید. برای تزئین آن هم از زرشک استفاده می‌کنند.",
                ImageOne=System.IO.File.ReadAllBytes("Images/lobia.jpg"),
                ImageTwo=System.IO.File.ReadAllBytes("Images/lobia2.jpg"),
                link="https://chishi.ir/1843-kookoo-loobia-sabz/",
},
            new item {
                id=6,
                name="آش اوماج",
                description="تبریزی‌ها معمولا آش اوماج را زمستان‌ها می‌پزند که برای سرما‌خوردگی بسیار مفید است. برای تهیه‌ی آش اوماج از پیاز فراوان، عدس، رشته یا اوماج (برای تهیه اوماج آرد را خمیر کرده و سپس آن را رنده می‌کنند)، ریحان، مرزه، تره، فلفل و زردچوبه استفاده می‌کنند.",
                ImageOne=System.IO.File.ReadAllBytes("Images/omaj.jpg"),
                ImageTwo=System.IO.File.ReadAllBytes("Images/omaj2.jpg"),
                link="https://chishi.ir/3563-ash-oumaj/",
},
    };



        [HttpGet]
        public object GetFoods()
        {
            return new
            {
                title= "معروف ترین غذا های استان آذربایجان شرقی",
                items=foods
            };




        }

    }
}
