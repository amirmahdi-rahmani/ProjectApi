﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApi.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    
    public class FamousController: ControllerBase
    {
       
        private List<item> famous = new List<item>()
    {
        new item {
            id=1,
            name="بابک خرمدین",
            description= "بابک خرمدین (درگذشتۀ صفر ۲۲۳ / ژانویۀ ۸۳۸)، رهبر اصلی مبارزان ایرانی علیه سلطه خلافت عباسی و از پیروان جنبش خرمدینان بود که پس از مرگ ابومسلم خراسانی، بر خلافت عباسی شورید. خرمدینان، مرگ ابومسلم را انکار کردند و معتقد بودند که او باز خواهد گشت تا عدالت را در جهان، برقرار کند. در دوران خلافت عباسیان، آذربایجان، کانون مقاومت طولانی‌مدت و خطرناک علیه خلافت بود که توسط بابک خرمدین، رهبری می‌شد و بر شمال غربی ایران، تأثیر گذاشته بود و بیش از ۲۰ سال — از ۲۰۱ ه‍.ق / ۸۱۶ م تا ۲۲۲ ه‍.ق /۸۳۷ م — طول کشید. از نگاه کلیفورد ادموند باسورث، این مقاومت قطعاً پایه‌های دینی داشت اما ممکن است که پایه‌های سیاسی-اجتماعی نیز داشته باشد. شورش او به روشنی از حس ضد عربی ایرانیان در آذربایجان بهره می‌برده‌است تعداد نیروهای لشکر بابک را در ابوالمعالی ۱۰۰ هزار نفر، در تنبیه الاشراف مسعودی ۲۰۰ هزار نفر، در تاریخ بغدادی ۳۰۰ هزار نفر یا بیشمار و در تبصره العوام بیشمار ذکر کرده‌اندکه بی شک مبالغه‌آمیز است ولی حداقل دلالت بر بزرگ بودن لشکر آن دارد.      ",
            ImageOne=System.IO.File.ReadAllBytes("Images/babak1.jpg"),
            ImageTwo=System.IO.File.ReadAllBytes("Images/babak2.jpg"),
            link= "https://fa.wikipedia.org/wiki/%D8%A8%D8%A7%D8%A8%DA%A9_%D8%AE%D8%B1%D9%85%D8%AF%DB%8C%D9%86",
        },
        new item {
           id=2,
           name= "استاد شهریار",
           description="رخشنده اعتصامی (۲۵ اسفندِ ۱۲۸۵ – ۱۵ فروردینِ ۱۳۲۰)، معروف به پروین اعتصامی، شاعر ایرانی بود. او بیشتر به‌دلیل به کار بردن سبک شعریِ مناظره در شعرهایش معروف است. مضامین و معانی شعرهای او توصیف‌کنندهٔ دلبستگیِ عمیقش به پدر، استعداد و شوقِ فراوانش به آموختنِ دانش، روحیهٔ ظلم‌ستیزی و مخالفت با ستم و ستمگران، حمایت از حقوقِ زنان و ابراز همدلی و همدردی با محرومان و ستم‌دیدگان است. او را «مشهورترین شاعر زن ایران» گفته‌اند. اعتصامی از کودکی فارسی و انگلیسی و عربی را نزدِ پدرش آموخت و از همان کودکی زیرِ نظرِ پدر و استادانی چون علی‌اکبر دهخدا و محمّدتقی بهار سرودنِ شعر را آغاز کرد. پدرش، یوسف اعتصامی آشتیانی، شاعر و مترجم بود و در شکل‌گیریِ زندگیِ هنریِ پروین و کشفِ توانایی‌ها و ذوق و گرایشش به شعر نقشِ مهمّی داشت. اعتصامی در بیست‌وهشت‌سالگی ازدواج کرد؛ امّا، به خاطرِ اختلافِ فکری با همسرش، پس از چندی از او جدا شد. پس از جدایی مدّتی در کتابخانهٔ دانشسرای عالی تهران به کتابداری مشغول شد. یگانه اثرِ چاپ و منتشرشده از پروین دیوانِ اشعار اوست، که دارای ۶۰۶ شعر شامل اشعاری در قالب‌های مثنوی، قطعه و قصیده است. شعرهای پروین پیش از چاپ به‌صورت مجموعه و کتاب، در مجلهٔ بهار و منتخبات آثار از ضیاء هشترودی و امثال و حکم از دهخدا، چاپ می‌شدند. موفقیت اولین چاپ دیوان اشعار او سبب پیدایش زمینه برای چاپ‌های بعدی شعرهای او شد. اعتصامی پیش از چاپ دومین نوبت از دیوان اشعارش، بر اثر بیماری حصبه در سی‌وپنج‌سالگی در تهران درگذشت و در حرم فاطمهٔ معصومه، در آرامگاه خانوادگی‌اش، به خاک سپرده شد. زادروز او روز بزرگداشت پروین اعتصامی نام‌گذاری شده‌است.",
           ImageOne=System.IO.File.ReadAllBytes("Images/Shahriyar.jpg"),
           ImageTwo=System.IO.File.ReadAllBytes("Images/Shahriyar2.jpg"),
           link= "https://fa.wikipedia.org/wiki/%D9%BE%D8%B1%D9%88%DB%8C%D9%86_%D8%A7%D8%B9%D8%AA%D8%B5%D8%A7%D9%85%DB%8C",

        },
        new item {
            id=3,
            name= "پروین اعتصامی",
            description="رخشنده اعتصامی (۲۵ اسفندِ ۱۲۸۵ – ۱۵ فروردینِ ۱۳۲۰)، معروف به پروین اعتصامی، شاعر ایرانی بود. او بیشتر به‌دلیل به کار بردن سبک شعریِ مناظره در شعرهایش معروف است. مضامین و معانی شعرهای او توصیف‌کنندهٔ دلبستگیِ عمیقش به پدر، استعداد و شوقِ فراوانش به آموختنِ دانش، روحیهٔ ظلم‌ستیزی و مخالفت با ستم و ستمگران، حمایت از حقوقِ زنان و ابراز همدلی و همدردی با محرومان و ستم‌دیدگان است. او را «مشهورترین شاعر زن ایران» گفته‌اند. اعتصامی از کودکی فارسی و انگلیسی و عربی را نزدِ پدرش آموخت و از همان کودکی زیرِ نظرِ پدر و استادانی چون علی‌اکبر دهخدا و محمّدتقی بهار سرودنِ شعر را آغاز کرد. پدرش، یوسف اعتصامی آشتیانی، شاعر و مترجم بود و در شکل‌گیریِ زندگیِ هنریِ پروین و کشفِ توانایی‌ها و ذوق و گرایشش به شعر نقشِ مهمّی داشت. اعتصامی در بیست‌وهشت‌سالگی ازدواج کرد؛ امّا، به خاطرِ اختلافِ فکری با همسرش، پس از چندی از او جدا شد. پس از جدایی مدّتی در کتابخانهٔ دانشسرای عالی تهران به کتابداری مشغول شد. یگانه اثرِ چاپ و منتشرشده از پروین دیوانِ اشعار اوست، که دارای ۶۰۶ شعر شامل اشعاری در قالب‌های مثنوی، قطعه و قصیده است. شعرهای پروین پیش از چاپ به‌صورت مجموعه و کتاب، در مجلهٔ بهار و منتخبات آثار از ضیاء هشترودی و امثال و حکم از دهخدا، چاپ می‌شدند. موفقیت اولین چاپ دیوان اشعار او سبب پیدایش زمینه برای چاپ‌های بعدی شعرهای او شد. اعتصامی پیش از چاپ دومین نوبت از دیوان اشعارش، بر اثر بیماری حصبه در سی‌وپنج‌سالگی در تهران درگذشت و در حرم فاطمهٔ معصومه، در آرامگاه خانوادگی‌اش، به خاک سپرده شد. زادروز او روز بزرگداشت پروین اعتصامی نام‌گذاری شده‌است.",
            ImageOne=System.IO.File.ReadAllBytes("Images/parvin.jpg"),
            ImageTwo=System.IO.File.ReadAllBytes("Images/parvin2.jpg"),
            link= "https://fa.wikipedia.org/wiki/%D9%BE%D8%B1%D9%88%DB%8C%D9%86_%D8%A7%D8%B9%D8%AA%D8%B5%D8%A7%D9%85%DB%8C",

        },
        new item {
            id=4,
            name= "شمس تبریزی",
            description="محمد بن علی بن ملک‌داد تبریزی ملقب به شمس‌الدین یا شمس تبریزی (زاده ۵۸۲ – درگذشته ۶۴۵ هجری قمری) از صوفیان ایرانی مسلمان مشهور سدهٔ هفتم هجری است. سخنان وی را که در مجالس مختلف بر زبان آورده، مریدان گردآوری کرده‌اند که به نام «مقالات شمس تبریزی» معروف است.پیشینه از زندگی شمس تبریزی و احوال شخصی او تا آنگاه که مقالات شمس کشف شد، خبر مهمی در دست نبود. قدیمی‌ترین مدارک دربارهٔ شمس تبریزی، ابتدانامه سلطان ولد و رساله سپهسالار است که گفته «هیچ آفریده‌ای را بر حال شمس اطلاعی نبوده چون شهرت خود را پنهان می‌داشت و خویش را در پرده اسرار فرو می‌پیچید». در کتاب مقالات اگر چه شمس تبریزی به شرح احوال و معرفی پیشینه خود نپرداخته‌است اما می‌توان او را از میان توصیفات و خاطرات بازشناخت، توصیفاتی که او به مناسبت‌های گوناگون دربارهٔ افراد و اقوال مطرح می‌کند.",
            ImageOne=System.IO.File.ReadAllBytes("Images/shams.jpg"),
            ImageTwo=System.IO.File.ReadAllBytes("Images/shams2.jpg"),
            link= "https://fa.wikipedia.org/wiki/%D8%B4%D9%85%D8%B3_%D8%AA%D8%A8%D8%B1%DB%8C%D8%B2%DB%8C",

        },
        new item {
            id=5,
            name= "باقرخان",
            description="باقر خان (۱۲۴۰ خورشیدی تبریز – ۱۲۹۵ خورشیدی قصر شیرین) با لقب افتخاری سالار ملّی، از مبارزان جنبش مشروطه ایران بود. زندگی‌نامه باقر خان فرزند حاج رضا بنا و شغل وی بنایی بود، وی در جریان مشروطیت به مجاهدین پیوست. ریاست مجاهدین محله خیابان تبریز را به‌عهده داشت. پس از به توپ بستن مجلس، به دستور انجمن ایالتی همراه با ستارخان به جنگ مسلحانه با قشون دولتی که تبریز را در محاصره داشت، پرداخت. هم‌زمان با او، ستارخان در محله امیرخیز، محله دیگر تبریز، با قوای دولتی جنگ می‌کرد. در اثر همکاری او با ستّارخان کار مشروطه طلبان پیشرفت کرده و تبریز از محاصره درآمد. پس از پیروزی مجاهدین، مجلس شورای ملی باقرخان را به لقب سالار ملی ملقب ساخت، و از او تقدیر نمود",
            ImageOne=System.IO.File.ReadAllBytes("Images/bager.jpg"),
            ImageTwo=System.IO.File.ReadAllBytes("Images/bager2.jpg"),
            link= "https://fa.wikipedia.org/wiki/%D8%A8%D8%A7%D9%82%D8%B1%D8%AE%D8%A7%D9%86",

        },
        new item  {
            id= 6,
            name= "ستارخان",
            description="ستارخان قراچه‌داغی (زاده ۲۸ مهر ۱۲۴۵ – درگذشته ۲۵ آبان ۱۲۹۳) از سرداران جنبش مشروطه ایران ملقب به سردار ملی است. وی در برابر نیروهای دولتی ضد مشروطه در تبریز ایستاد.زندگی‌نامه ستار خان سومین پسر حاج حسن قره‌داغی در ۲۸ مهر ۱۲۴۵ خورشیدی در روستای سردارکندی در شهرستان ورزقان به دنیا آمد. وی در مقابل قشون عظیم محمدعلی‌شاه پس از به توپ بستن مجلس شورای ملی و تعطیلی آن که برای طرد و دستگیر کردن مشروطه‌خواهان تبریز به آذربایجان گسیل شده‌بود، ایستادگی کرد و بنای مقاومت گذارد. ستارخان مردم را ضد اردوی دولتی فراخواند و خود رهبری آن را بر عهده گرفت و به همراه سایر مجاهدان و باقرخان -سالار ملی- مدت یک سال در برابر قوای دولتی ایستادگی کرد و نگذاشت تبریز به دست طرفداران محمدعلی‌شاه بیفتد. اختلاف او با شاهان قاجار و اعتراض به ظلم و ستم آنان، به زمان کودکی‌اش برمی‌گشت",
            ImageOne=System.IO.File.ReadAllBytes("Images/sattar.jpg"),
            ImageTwo=System.IO.File.ReadAllBytes("Images/sattar2.jpg"),
            link= "https://fa.wikipedia.org/wiki/%D8%B3%D8%AA%D8%A7%D8%B1%D8%AE%D8%A7%D9%86",
    },
    };

        

        [HttpGet]
        public object GetFamous()
        {
            return new
            {
                title= "مشاهیر آذربایجان شرقی",
                items=famous
            };
        }

    }
}
