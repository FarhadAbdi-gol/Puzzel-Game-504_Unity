
using System.Collections.Generic;


public class PageFree 
{

    public string Text { get; set; }
    public List<string> Pages { get; set; }

    private static List<PageFree> _pageListFree = null;

    public static PageFree RandomPageFree;

    public static int FreeCurrentPage1 = 0;
    public static int FreeCurrentPage2 = 1;

    public static PageFree GetRandomPageFree()
    {
        List<PageFree> pageList = PageFree.PageListFree;

        int num = 0;
        PageFree pge = pageList[num];
        pge.Pages = new List<string>();

        string[] words = pge.Text.Split(' ');

        string page = "";
        int wordCnt = 0;

        foreach (string word in words)
        {
            wordCnt++;
            if (wordCnt > 167)
            {
                pge.Pages.Add(page);
                page = "";
                wordCnt = 0;
            }
            page += string.Format("{0} ", word);
        }
        pge.Pages.Add(page);

        RandomPageFree = pge;

        return pge;
    }
 
    public static List<PageFree> PageListFree
    {
        get
        {
            if (_pageListFree == null)
            {
                _pageListFree =new List<PageFree>
                {
                    new PageFree
                    {
                        Text ="<align=center> <b> پیشگفتار </b> </align>\n\n مجموعه حاضر جهت یادگیری و بخاطرسپاری آسان واژه های زبان انگلیسی نوشته شده است. در این مجموعه از روش ابداعی <color=blue> کدینگ درون داستان </color> استفاده شده است که برای اولین بار در قالب نرم افزار موبایلی ارائه می شود. <color=blue> کتاب 504 واژه ضروری زبان انگلیسی </color>، اولین کتاب برای پیاده سازی این روش جهت آموزش زبان انگلیسی می باشد، کتاب های منبع دیگر زبان توسط گروه آموزشی فریار در حال آماده سازی است.\n این روش آموزش لغات زبان انگلیسی و کل این مجموعه توسط <color=blue> مهندس فرهاد عبدی گل </color>، فارغ التحصیل کارشناسی ارشد رشته مکانیک بیوسیستم، طراحی و برنامه نویسی شده است.\n در خلق داستان های کوتاه فارسی از کدها <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> "
                        +" و معانی واژه ها الهام گرفته شده و هر گونه تخیل و استفاده از نام اشخاص و مکان، همچنین استفاده از نام اقوام و شغل ها و ... بدون غرض بوده و صرفا جهت پیوند <color=blue> ترکیب های کد و واژه </color> به کار برده شده است و به جهت قرار گرفتن کد و واژه کنار هم از نظر قواعد نگارشی متون فارسی، استاندارد لازم را برای چاپ ندارد.\n حق کپی و رایت این مجموعه برای گروه آموزشی فریار محفوظ است و هرگونه سوء استفاده از این نرم افزار و مطالب آن خلاف قوانین اخلاقی بوده و قابل بخشش نیست.\n در این نرم افزار <color=blue> بازی جورچین 504 </color>، برای اولین بار ارائه شده است که به علاقه مندان یادگیری لغات زبان انگلیسی کمک می کند یادگیری خودشان را به چالش بکشانند و لغات را برای همیشه در حافظه بلند مدت خود ثبت کنند. <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> "
                        +"<align=center> <b> داستان اول </b> </align>\n\n  به مقصد میدان جنگ، شهر <link=Aa> <color=blue> آبادان </color> را <color=red> ترک کردیم </color> </link>، در این میان، <link=Ab> <color=blue> آن عکاس امید </color> <color=red> غیرعادی </color> </link> به نظر می آمد در حالی که اسلحه او دوربینش بود. او آشنا به راه بود و ما را همراهی میکرد و عادت کرده بود تازه واردها را راهنمایی کند و از لحظه های سخت و سنگین آنها خاطره بسازد. یکی از همرزم ها <link=Ac> <color=blue> بچه لر </color> و <color=red> مجرد </color> </link> بود همچنین مدرک <link=Ac> <color=red> لیسانس </color> </link> داشت همراه خود همیشه <link=Ad> <color=blue> ژله داشت </color> و <color=red> حسود </color> </link> نبود. با چند تا از بچه های <link=Ae> <color=blue> گیلانی </color> <color=red> شجاع </color> </link> آشنا شدیم. از بچه های ترک،<link=Af> <color=blue> تک تیرانداز </color> با <color=red> مهارتی </color> </link> همراه ما آمده بود.\n در این میان یاد سخن استادم افتادم که می گفت در میدان جنگ نیز کینه به دل نداشته باشید. <b> <b> </b> </b> "
                        +"<link=Ag> <color=blue> استاد </color> <color=red> سوگند می خورد </color> </link>، آدم <link=Ah> <color=blue> کینه ای </color> <color=red> شدیداَ حساس </color> </link> می شود و همیشه به فکر انتقام است تااینکه بفکر دفاع از خاک و مال و ناموس خود باشد .\n جهت حفظ اطلاعات و انتقال آن به همرزم های بعدی، از عکاس امید پرسیدیم: <link=Ai> <color=blue> کجا را علی (فرمانده) </color> <color=red> تعیین کرده </color> </link> بود که <link=Aj> <color=blue> ده تا </color> از <color=red> اطلاعات </color> </link> سری را جاسازی کنیم؟\n به خط مقدم نزدیکتر می شدیم و همرزم های پشت جبهه را می دیدیم، آنها <link=Ak> <color=red> بیکار </color> ننشسته بودند <color=blue> و کانتینر </color> <color=red> خالی </color> </link> می کردند و بار مهمات را با <link=Al> <color=blue> هر شیب </color> به <color=red> سختی </color> و <color=red> مشقت </color> </link> عبور می دادند تا به هم رزمان برسانند ...\n\n\n <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> <b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> </b> "
                        +"<align=center> <b> داستان دوم </b> </align>\n\n زمستان سردی بود هوا مثل <link=Ba> <color=blue> فریزر </color> <color=red> منجمد </color> </link> می کرد، زنگ در به صدا درآمد از اداره پست آمده بودند. در را باز کردم و دیدم سرما <link=Bb> <color=blue> نامه بر </color> را <color=red> بی حس </color> </link> کرده بود. من و دوستم «تمپیت» در خانه تنها بودیم، از نامه بر و راننده اش دعوت کردم داخل شده و کمی گرم شوند، <link=Bc> <color=blue> اینها بیت </color> (خانه) ما <color=red> ساکن شدند </color> </link>. نامه بر، «پریل» نام داشت و آدم شوخ طبع و خون گرمی بود بعد از اینکه صمیمی شدیم، دوستم <link=Bd> <color=blue> تمپیت </color> <color=red> هوس کرده </color> </link> بود یک وعده ناهار مفتی بخورد برای همین پیشنهاد داد که بازی شرطی انجام دهیم. من و دوستم تمپیت یک گروه شدیم و پریل و راننده اش یک گروه تشکیل دادند و بازی خطرناکی را شروع کردیم، <b> <b> <b> <b> <b> <b> <b> <b> <b> </b> </b> </b> </b> </b> </b> </b> </b> </b> "
                        +"<link=Be> <color=blue> واگیر </color> بودن <color=red> شرط بندی </color> </link> راننده و <link=Bf> <color=blue> پریل </color> را <color=red> به خطر انداخت </color> </link>. مشغول بازی بودیم که باران شدیدی شروع شد و ناگهان با صدای مهیب رعد و برق تمپیت <link=Bg> <color=blue> شریک </color> من <color=red> فریاد </color> </link> زد، پریل کنترل خود را از دست داد و فاجعه ناگواری رخ داد، پریل از هوش رفت و <link=Bh> <color=blue> سینی ستاره دار </color> <color=red> گمراه کننده </color> </link> از دست پریل رها شد و به چشم راننده اصابت کرد و چشم او صدمه دید. راننده <link=Bi> <color=blue> کور مثل </color> <color=red> جنازه </color> </link> افتاد.\n من و تمپیت تصمیم گرفتیم از شر پریل و راننده اش خلاص شویم، آنها را بیرون از خانه کنار ماشین شان <link=Bj> <color=blue> روی یک لاین (خط) </color> <color=red> دراز کردیم </color> </link>، تا صحنه سازی کنیم و هوای نامساعد را مقصر اتفاق معرفی کنیم. به خانه برگشتیم و <link=Bk> <color=blue> دستمال </color> جامانده پریل <color=red> پریشانم کرد </color> </link>، برداشتم و از پنجره بیرون انداختم <link=Bl> <color=blue> که آن را سیل </color> در خود <color=red> پنهان کند </color> </link> ...\n\n\n\n\n\n  <align=center> <color=blue> با مرحله اول بازی جورچین 504 \n یادگیری خودتان را به چالش بکشید </color> </align>\n "
                    }
                };
            }

            return _pageListFree;
        }
    }
}
