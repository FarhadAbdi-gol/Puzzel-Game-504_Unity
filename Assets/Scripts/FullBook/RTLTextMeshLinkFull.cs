// In The Name of Allah
using UnityEngine;
using UnityEngine.EventSystems;
using RTLTMPro;
using TMPro;

public class RTLTextMeshLinkFull : MonoBehaviour, IPointerClickHandler
{
    RTLTextMeshPro rtltextMeshPro;
    Canvas canvasRTL;
    Camera _cameraRTL;
    public GameObject PanelShowWords;
    public RTLTextMeshPro CodeShow;
    public TextMeshProUGUI WordsShow;
    public AudioSource audioSource;
    public AudioClip[] WordsClip;


    void Awake()
    {
        rtltextMeshPro = gameObject.GetComponent<RTLTextMeshPro>();
        canvasRTL = gameObject.GetComponentInParent<Canvas>();
        _cameraRTL = gameObject.GetComponentInParent<Camera>();

        if (canvasRTL.renderMode == RenderMode.ScreenSpaceOverlay)
        {
            _cameraRTL = null;
        }
        else
        {
            _cameraRTL = canvasRTL.worldCamera;
        }
    }
    public void PlaySounds(AudioClip sound)
    {
        audioSource.PlayOneShot(sound);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(rtltextMeshPro, Input.mousePosition, _cameraRTL);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = rtltextMeshPro.textInfo.linkInfo[linkIndex];
            switch (linkInfo.GetLinkID())
            {
                case "farhad":
                    {
                        Application.OpenURL("https://www.instagram.com/farhadabdifariad/");
                    }
                    break;
                //Story 1
                case "Aa":
                    {
                        PlaySounds(WordsClip[0]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "abandon";
                        CodeShow.text = "آبادان" + " <color=green>+</color> " + "ترک کردن، رها کردن";
                    }
                    break;
                case "Ab":
                    {
                        PlaySounds(WordsClip[9]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unaccustomed";
                        CodeShow.text = "آن عکاس امید" + " <color=green>+</color> " + "غیر عادی";
                    }
                    break;
                case "Ac":
                    {
                        PlaySounds(WordsClip[10]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "bachelor";
                        CodeShow.text = "بچه لر" + " <color=green>+</color> " + "مجرد، لیسانس";
                    }
                    break;
                case "Ad":
                    {
                        PlaySounds(WordsClip[2]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "jealous";
                        CodeShow.text = "ژله داشت" + " <color=green>+</color> " + "حسود، حسادت آمیز";
                    }
                    break;
                case "Ae":
                    {
                        PlaySounds(WordsClip[7]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "gallant";
                        CodeShow.text = "گیلانی" + " <color=green>+</color> " + "شجاع، دلیر";
                    }
                    break;
                case "Af":
                    {
                        PlaySounds(WordsClip[3]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tact";
                        CodeShow.text = "تک تیرانداز" + " <color=green>+</color> " + "مهارت، سلیقه";
                    }
                    break;
                case "Ag":
                    {
                        PlaySounds(WordsClip[4]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "oath";
                        CodeShow.text = "استاد" + " <color=green>+</color> " + "قسم خوردن، سوگند";
                    }
                    break;
                case "Ah":
                    {
                        PlaySounds(WordsClip[1]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "keen";
                        CodeShow.text = "کینه ای" + " <color=green>+</color> " + "حساس، قوی";
                    }
                    break;
                case "Ai":
                    {
                        PlaySounds(WordsClip[11]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "qualify";
                        CodeShow.text = "کجا را علی فرمانده" + " <color=green>+</color> " + "تعیین کردن";
                    }
                    break;
                case "Aj":
                    {
                        PlaySounds(WordsClip[8]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "data";
                        CodeShow.text = "ده تا" + " <color=green>+</color> " + "اطلاعات، شواهد";
                    }
                    break;
                case "Ak":
                    {
                        PlaySounds(WordsClip[5]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vacant";
                        CodeShow.text = "و کانتینر" + " <color=green>+</color> " + "خالی، بیکار";
                    }
                    break;
                case "Al":
                    {
                        PlaySounds(WordsClip[6]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "hardship";
                        CodeShow.text = "هر شیب" + " <color=green>+</color> " + "سختی، مشقت";
                    }
                    break;
                //Story 2
                case "Ba":
                    {
                        PlaySounds(WordsClip[15]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "frigid";
                        CodeShow.text = "فریزر" + " <color=green>+</color> " + "بسیار سرد، منجمد";
                    }
                    break;
                case "Bb":
                    {
                        PlaySounds(WordsClip[17]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "numb";
                        CodeShow.text = "نامه بر" + " <color=green>+</color> " + "بی حس، کرخت";
                    }
                    break;
                case "Bc":
                    {
                        PlaySounds(WordsClip[16]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "inhabit";
                        CodeShow.text = "این ها بیت" + " <color=green>+</color> " + "ساکن شدن";
                    }
                    break;
                case "Bd":
                    {
                        PlaySounds(WordsClip[22]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tempt";
                        CodeShow.text = "تمپیت" + " <color=green>+</color> " + "هوس کردن، وسوسه شدن";
                    }
                    break;
                case "Be":
                    {
                        PlaySounds(WordsClip[23]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wager";
                        CodeShow.text = "واگیر" + " <color=green>+</color> " + "شرط بندی، شرط بستن";
                    }
                    break;
                case "Bf":
                    {
                        PlaySounds(WordsClip[18]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "peril";
                        CodeShow.text = "پریل" + " <color=green>+</color> " + "به خطر انداختن، خطر";
                    }
                    break;
                case "Bg":
                    {
                        PlaySounds(WordsClip[20]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "shriek";
                        CodeShow.text = "شریک" + " <color=green>+</color> " + "فریاد، جیغ";
                    }
                    break;
                case "Bh":
                    {
                        PlaySounds(WordsClip[21]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "sinister";
                        CodeShow.text = "سینی ستاره دار" + " <color=green>+</color> " + "گمراه کننده، نادرست";
                    }
                    break;
                case "Bi":
                    {
                        PlaySounds(WordsClip[12]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "corpse";
                        CodeShow.text = "کور مثل" + " <color=green>+</color> " + "جسد، جنازه";
                    }
                    break;
                case "Bj":
                    {
                        PlaySounds(WordsClip[19]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "recline";
                        CodeShow.text = "روی یک لاین" + " <color=green>+</color> " + "دراز کشیدن";
                    }
                    break;
                case "Bk":
                    {
                        PlaySounds(WordsClip[14]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "dismal";
                        CodeShow.text = "دستمال" + " <color=green>+</color> " + "پریشان کننده";
                    }
                    break;
                case "Bl":
                    {
                        PlaySounds(WordsClip[13]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "conceal";
                        CodeShow.text = "که آن سیل" + " <color=green>+</color> " + "پنهان کردن، پوشاندن";
                    }
                    break;
                //Story 3
                case "Ca":
                    {
                        PlaySounds(WordsClip[28]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "persuade";
                        CodeShow.text = "پر سود" + " <color=green>+</color> " + "قانع کردن، راضی کردن";
                    }
                    break;
                case "Cb":
                    {
                        PlaySounds(WordsClip[35]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wholesale";
                        CodeShow.text = "کل سال" + " <color=green>+</color> " + "عمده فروشی";
                    }
                    break;
                case "Cc":
                    {
                        PlaySounds(WordsClip[34]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "devise";
                        CodeShow.text = "دیواری" + " <color=green>+</color> " + "تدبیر کردن، اختراع";
                    }
                    break;
                case "Cd":
                    {
                        PlaySounds(WordsClip[32]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "expensive";
                        CodeShow.text = "عکس پنسدار" + " <color=green>+</color> " + "گران";
                    }
                    break;
                case "Ce":
                    {
                        PlaySounds(WordsClip[24]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "typical";
                        CodeShow.text = "تیپ کلی" + " <color=green>+</color> " + "نوع";
                    }
                    break;
                case "Cf":
                    {
                        PlaySounds(WordsClip[33]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "talent";
                        CodeShow.text = "تا لنت" + " <color=green>+</color> " + "توانایی، استعداد ژنی";
                    }
                    break;
                case "Cg":
                    {
                        PlaySounds(WordsClip[31]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "visible";
                        CodeShow.text = "وسط سیبل" + " <color=green>+</color> " + "دیدنی";
                    }
                    break;
                case "Ch":
                    {
                        PlaySounds(WordsClip[25]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "minimum";
                        CodeShow.text = "مینیمم" + " <color=green>+</color> " + "کمترین";
                    }
                    break;
                case "Ci":
                    {
                        PlaySounds(WordsClip[26]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "scarce";
                        CodeShow.text = "اسکار" + " <color=green>+</color> " + "کمیاب، اندک";
                    }
                    break;
                case "Cj":
                    {
                        PlaySounds(WordsClip[27]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "annual";
                        CodeShow.text = "دندان وال" + " <color=green>+</color> " + "یکساله، سالانه";
                    }
                    break;
                case "Ck":
                    {
                        PlaySounds(WordsClip[29]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "essential";
                        CodeShow.text = "اصلا شال" + " <color=green>+</color> " + "ضروری، واجب";
                    }
                    break;
                case "Cl":
                    {
                        PlaySounds(WordsClip[30]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "blend";
                        CodeShow.text = "بلند" + " <color=green>+</color> " + "ترکیب، مخلوط کردن";
                    }
                    break;
                //Story 4
                case "Da":
                    {
                        PlaySounds(WordsClip[37]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Eliminate";
                        CodeShow.text = "الی مینا" + " <color=green>+</color> " + "حذف کردن";
                    }
                    break;
                case "Db":
                    {
                        PlaySounds(WordsClip[38]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Villain";
                        CodeShow.text = "ویلای این ها" + " <color=green>+</color> " + "بدذات، پست";
                    }
                    break;
                case "Dc":
                    {
                        PlaySounds(WordsClip[36]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Vapor";
                        CodeShow.text = "وافور" + " <color=green>+</color> " + "بخار، تبخیر کردن";
                    }
                    break;
                case "Dd":
                    {
                        PlaySounds(WordsClip[39]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Dense";
                        CodeShow.text = "دوا، جنسی" + " <color=green>+</color> " + "چگالی، دانسیته";
                    }
                    break;
                case "De":
                    {
                        PlaySounds(WordsClip[41]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Humid";
                        CodeShow.text = "حامد" + " <color=green>+</color> " + "خیس، نمناک";
                    }
                    break;
                case "Df":
                    {
                        PlaySounds(WordsClip[43]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Descend";
                        CodeShow.text = "دو سانتی" + " <color=green>+</color> " + "پایین آمدن، فرود آمدن";
                    }
                    break;
                case "Dg":
                    {
                        PlaySounds(WordsClip[44]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Circulate";
                        CodeShow.text = "سرو کله اش" + " <color=green>+</color> " + "گردش درآوردن، بخشنامه کردن";
                    }
                    break;
                case "Dh":
                    {
                        PlaySounds(WordsClip[47]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Vanish";
                        CodeShow.text = "و نیش" + " <color=green>+</color> " + "ناپدید شدن، غیب شدن";
                    }
                    break;
                case "Di":
                    {
                        PlaySounds(WordsClip[45]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Enormous";
                        CodeShow.text = "این آرمی است" + " <color=green>+</color> " + "بزرگ، عظیم";
                    }
                    break;
                case "Dj":
                    {
                        PlaySounds(WordsClip[40]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Utilize";
                        CodeShow.text = "او تا لیز" + " <color=green>+</color> " + "استفاده کردن";
                    }
                    break;
                case "Dk":
                    {
                        PlaySounds(WordsClip[46]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Predict";
                        CodeShow.text = "پرده هایی که" + " <color=green>+</color> " + "پیش بینی کردن، پیش گویی کردن";
                    }
                    break;
                case "Dl":
                    {
                        PlaySounds(WordsClip[42]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "Theory";
                        CodeShow.text = "تئوری" + " <color=green>+</color> " + "فرضیه";
                    }
                    break;
                //Story 5
                case "Ea":
                    {
                        PlaySounds(WordsClip[52]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "majority";
                        CodeShow.text = "ما یجورایی" + " <color=green>+</color> " + "اکثریت، بیشترین";
                    }
                    break;
                case "Eb":
                    {
                        PlaySounds(WordsClip[53]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "assemble";
                        CodeShow.text = "اصلا موبایل" + " <color=green>+</color> " + "گرد آمدن، جمع شدن";
                    }
                    break;
                case "Ec":
                    {
                        PlaySounds(WordsClip[48]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tradition";
                        CodeShow.text = "ترددشان" + " <color=green>+</color> " + "آداب و رسوم، رسم";
                    }
                    break;
                case "Ed":
                    {
                        PlaySounds(WordsClip[54]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "explore";
                        CodeShow.text = "عکس پل روی" + " <color=green>+</color> " + "کاوش کردن، تحقیق کردن";
                    }
                    break;
                case "Ee":
                    {
                        PlaySounds(WordsClip[49]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rural";
                        CodeShow.text = "روی ریل" + " <color=green>+</color> " + "روستایی رعیت";
                    }
                    break;
                case "Ef":
                    {
                        PlaySounds(WordsClip[50]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "burden";
                        CodeShow.text = "بردن" + " <color=green>+</color> " + "بار، مسئولیت سنگین";
                    }
                    break;
                case "Eg":
                    {
                        PlaySounds(WordsClip[58]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "probe";
                        CodeShow.text = "بروید به" + " <color=green>+</color> " + "جستوجوکردن، بدقت وارسی کردن";
                    }
                    break;
                case "Eh":
                    {
                        PlaySounds(WordsClip[59]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "reform";
                        CodeShow.text = "روی فرم" + " <color=green>+</color> " + "اصلاح کردن، اصلاح شدن";
                    }
                    break;
                case "Ei":
                    {
                        PlaySounds(WordsClip[55]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "topic";
                        CodeShow.text = "توپی که" + " <color=green>+</color> " + "موضوع، عنوان";
                    }
                    break;
                case "Ej":
                    {
                        PlaySounds(WordsClip[56]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "debate";
                        CodeShow.text = "دو بیت" + " <color=green>+</color> " + "بحث، مناظره";
                    }
                    break;
                case "Ek":
                    {
                        PlaySounds(WordsClip[51]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "campus";
                        CodeShow.text = "کم پوست" + " <color=green>+</color> " + "فضای باز";
                    }
                    break;
                case "El":
                    {
                        PlaySounds(WordsClip[57]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "evade";
                        CodeShow.text = "او وعده داد" + " <color=green>+</color> " + "طفره رفتن، فرار کردن";
                    }
                    break;
                //Story 6
                case "Fa":
                    {
                        PlaySounds(WordsClip[67]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "popular";
                        CodeShow.text = "پاپ لری" + " <color=green>+</color> " + "معروف، نامدار";
                    }
                    break;
                case "Fb":
                    {
                        PlaySounds(WordsClip[63]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "employee";
                        CodeShow.text = "این پلویی" + " <color=green>+</color> " + "مستخدم، کارگر";
                    }
                    break;
                case "Fc":
                    {
                        PlaySounds(WordsClip[62]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "defect";
                        CodeShow.text = "دو فاکتور" + " <color=green>+</color> " + "کاستی، نقص";
                    }
                    break;
                case "Fd":
                    {
                        PlaySounds(WordsClip[61]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "detect";
                        CodeShow.text = "دو اتیکت" + " <color=green>+</color> " + "کشف کردن، پیداکردن";
                    }
                    break;
                case "Fe":
                    {
                        PlaySounds(WordsClip[66]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "undoubtedly";
                        CodeShow.text = "آن دو بتول" + " <color=green>+</color> " + "بدون شک، مسلم";
                    }
                    break;
                case "Ff":
                    {
                        PlaySounds(WordsClip[71]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "defraud";
                        CodeShow.text = "دو فرد" + " <color=green>+</color> " + "کلاهبرداری کردن، گول زدن";
                    }
                    break;
                case "Fg":
                    {
                        PlaySounds(WordsClip[69]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "client";
                        CodeShow.text = "کلی اینترنت" + " <color=green>+</color> " + "مشتری، موکل";
                    }
                    break;
                case "Fh":
                    {
                        PlaySounds(WordsClip[68]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "thorough";
                        CodeShow.text = "دروغ" + " <color=green>+</color> " + "کامل، تمام و کمال";
                    }
                    break;
                case "Fi":
                    {
                        PlaySounds(WordsClip[64]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "neglect";
                        CodeShow.text = "نقل کتاب" + " <color=green>+</color> " + "غفلت کردن";
                    }
                    break;
                case "Fj":
                    {
                        PlaySounds(WordsClip[65]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "deceive";
                        CodeShow.text = "دو سیب" + " <color=green>+</color> " + "گول زدن، فریفتن";
                    }
                    break;
                case "Fk":
                    {
                        PlaySounds(WordsClip[70]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "comprehensive";
                        CodeShow.text = "کمپرسی" + " <color=green>+</color> " + "همه، جامع، فراگیر";
                    }
                    break;
                case "Fl":
                    {
                        PlaySounds(WordsClip[60]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "approach";
                        CodeShow.text = "آبرویشان" + " <color=green>+</color> " + "نزدیک شدن";
                    }
                    break;
                //Story 7
                case "Ga":
                    {
                        PlaySounds(WordsClip[79]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "torrent";
                        CodeShow.text = "تورنتوی" + " <color=green>+</color> " + "سیلاب، سیل";
                    }
                    break;
                case "Gb":
                    {
                        PlaySounds(WordsClip[77]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "denounce";
                        CodeShow.text = "دین انسان" + " <color=green>+</color> " + "سرزنش کردن، نکوهش کردن";
                    }
                    break;
                case "Gc":
                    {
                        PlaySounds(WordsClip[78]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unique";
                        CodeShow.text = "اونی که" + " <color=green>+</color> " + "بی همتا، بی نظیر";
                    }
                    break;
                case "Gd":
                    {
                        PlaySounds(WordsClip[83]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unforeseen";
                        CodeShow.text = "آن فرصت" + " <color=green>+</color> " + "پیش بینی نشده";
                    }
                    break;
                case "Ge":
                    {
                        PlaySounds(WordsClip[72]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "postpone";
                        CodeShow.text = "پست پونه" + " <color=green>+</color> " + "به تاخیر انداختن، تعویق انداختن";
                    }
                    break;
                case "Gf":
                    {
                        PlaySounds(WordsClip[80]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "resent";
                        CodeShow.text = "روی سنت" + " <color=green>+</color> " + "خشمگین شدن، عصبانی شدن";
                    }
                    break;
                case "Gg":
                    {
                        PlaySounds(WordsClip[74]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "massive";
                        CodeShow.text = "مسیح" + " <color=green>+</color> " + "بزرگ، سنگین، عظیم";
                    }
                    break;
                case "Gh":
                    {
                        PlaySounds(WordsClip[73]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "consent";
                        CodeShow.text = "که آن سنت" + " <color=green>+</color> " + "اجازه دادن، موافقت کردن";
                    }
                    break;
                case "Gi":
                    {
                        PlaySounds(WordsClip[75]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "capsule";
                        CodeShow.text = "کپسول" + " <color=green>+</color> " + "کپسول، پوشش خود کپسول";
                    }
                    break;
                case "Gj":
                    {
                        PlaySounds(WordsClip[82]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "gloomy";
                        CodeShow.text = "گلویش می" + " <color=green>+</color> " + "دلگیر، تاریک، غم افزا";
                    }
                    break;
                case "Gk":
                    {
                        PlaySounds(WordsClip[76]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "preserve";
                        CodeShow.text = "رزرو" + " <color=green>+</color> " + "سالم نگه داشتن، ایمن کردن";
                    }
                    break;
                case "Gl":
                    {
                        PlaySounds(WordsClip[81]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "molest";
                        CodeShow.text = "مالی است" + " <color=green>+</color> " + "اذیت کردن، آزار دادن";
                    }
                    break;
                //Story 8
                case "Ha":
                    {
                        PlaySounds(WordsClip[87]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "variety";
                        CodeShow.text = "واریته" + " <color=green>+</color> " + "انواع و اقسام";
                    }
                    break;
                case "Hb":
                    {
                        PlaySounds(WordsClip[91]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prominent";
                        CodeShow.text = "پر روی مین" + " <color=green>+</color> " + "مهم، برجسته";
                    }
                    break;
                case "Hc":
                    {
                        PlaySounds(WordsClip[89]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "survive";
                        CodeShow.text = "سر واوی" + " <color=green>+</color> " + "زنده ماندن، نجات پیدا کردن";
                    }
                    break;
                case "Hd":
                    {
                        PlaySounds(WordsClip[94]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "reluctant";
                        CodeShow.text = "رو لاک" + " <color=green>+</color> " + "بی میل، مخالفت کردن";
                    }
                    break;
                case "He":
                    {
                        PlaySounds(WordsClip[85]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "amateur";
                        CodeShow.text = "یک موتور" + " <color=green>+</color> " + "آماتور، غیرحرفه ای";
                    }
                    break;
                case "Hf":
                    {
                        PlaySounds(WordsClip[88]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "valid";
                        CodeShow.text = "ولی" + " <color=green>+</color> " + "درست، صحیح، معتبر";
                    }
                    break;
                case "Hg":
                    {
                        PlaySounds(WordsClip[92]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "security";
                        CodeShow.text = "سیگاری" + " <color=green>+</color> " + "امنیت، آسایش، اطمینان خاطر";
                    }
                    break;
                case "Hh":
                    {
                        PlaySounds(WordsClip[90]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "weird";
                        CodeShow.text = "ورد" + " <color=green>+</color> " + "عجیب، خارق العاده";
                    }
                    break;
                case "Hi":
                    {
                        PlaySounds(WordsClip[86]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mediocre";
                        CodeShow.text = "میدی یا که" + " <color=green>+</color> " + "متوسط، حد وسط، میانه";
                    }
                    break;
                case "Hj":
                    {
                        PlaySounds(WordsClip[95]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "obvious";
                        CodeShow.text = "آب ویروسی" + " <color=green>+</color> " + "واضح، آشکار، مشخص";
                    }
                    break;
                case "Hk":
                    {
                        PlaySounds(WordsClip[84]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "exaggerate";
                        CodeShow.text = "اگر جرات  داری" + " <color=green>+</color> " + "سخن مبالغه آمیز، گزاف گویی";
                    }
                    break;
                case "Hl":
                    {
                        PlaySounds(WordsClip[93]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "bulky";
                        CodeShow.text = "بال کی" + " <color=green>+</color> " + "بزرگ، عظیم الجثه ";
                    }
                    break;
                //Story 9
                case "Ia":
                    {
                        PlaySounds(WordsClip[106]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "miniature";
                        CodeShow.text = "مینیاتوری" + " <color=green>+</color> " + "کوچک، مینیاتور";
                    }
                    break;
                case "Ib":
                    {
                        PlaySounds(WordsClip[104]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ignore";
                        CodeShow.text = "یک نوری" + " <color=green>+</color> " + "نادیده گرفتن";
                    }
                    break;
                case "Ic":
                    {
                        PlaySounds(WordsClip[107]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "source";
                        CodeShow.text = "سس" + " <color=green>+</color> " + "منبع، منشا، سرچشمه";
                    }
                    break;
                case "Id":
                    {
                        PlaySounds(WordsClip[102]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "resist";
                        CodeShow.text = "راضی است" + " <color=green>+</color> " + "مقاومت کردن، دوام آوردن، ایستادگی";
                    }
                    break;
                case "Ie":
                    {
                        PlaySounds(WordsClip[96]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vicinity";
                        CodeShow.text = "وسط نه" + " <color=green>+</color> " + "مجاورت، پیرامون همجوار";
                    }
                    break;
                case "If":
                    {
                        PlaySounds(WordsClip[99]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "document";
                        CodeShow.text = "دو کمد" + " <color=green>+</color> " + "سند و مدرک";
                    }
                    break;
                case "Ig":
                    {
                        PlaySounds(WordsClip[101]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "undeniable";
                        CodeShow.text = "ایشان دیده عیب" + " <color=green>+</color> " + "غیرقابل انکار";
                    }
                    break;
                case "Ih":
                    {
                        PlaySounds(WordsClip[100]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "conclude";
                        CodeShow.text = "کنکور" + " <color=green>+</color> " + "تمام کردن، تمام شدن";
                    }
                    break;
                case "Ii":
                    {
                        PlaySounds(WordsClip[98]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rage";
                        CodeShow.text = "رگ" + " <color=green>+</color> " + "عصبانی، خشمگین";
                    }
                    break;
                case "Ij":
                    {
                        PlaySounds(WordsClip[105]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "challenge";
                        CodeShow.text = "چالش" + " <color=green>+</color> " + "به مبارزه طلبیدن، چالش";
                    }
                    break;
                case "Ik":
                    {
                        PlaySounds(WordsClip[97]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "century";
                        CodeShow.text = "سن طوری که" + " <color=green>+</color> " + "قرن، سده";
                    }
                    break;
                case "Il":
                    {
                        PlaySounds(WordsClip[103]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "lack";
                        CodeShow.text = "لکه" + " <color=green>+</color> " + "نبودن، فقدان";
                    }
                    break;
                //Story 10
                case "Ja":
                    {
                        PlaySounds(WordsClip[113]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "masculine";
                        CodeShow.text = "مسئولین" + " <color=green>+</color> " + "مردانه";
                    }
                    break;
                case "Jb":
                    {
                        PlaySounds(WordsClip[115]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tendency";
                        CodeShow.text = "تا ندانستن" + " <color=green>+</color> " + "علاقه، تمایل، میل، توجه";
                    }
                    break;
                case "Jc":
                    {
                        PlaySounds(WordsClip[114]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "menace";
                        CodeShow.text = "مینی است" + " <color=green>+</color> " + "تهدید، تهدید کردن";
                    }
                    break;
                case "Jd":
                    {
                        PlaySounds(WordsClip[116]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "underestimate";
                        CodeShow.text = "آن درستی ما که" + " <color=green>+</color> " + "دست کم گرفتن، ناچیز پنداشتن";
                    }
                    break;
                case "Je":
                    {
                        PlaySounds(WordsClip[112]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "dread";
                        CodeShow.text = "دریده" + " <color=green>+</color> " + "ترس، بیم، وحشت";
                    }
                    break;
                case "Jf":
                    {
                        PlaySounds(WordsClip[111]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "compete";
                        CodeShow.text = "کمپوت" + " <color=green>+</color> " + "رقابت کردن، مسابقه دادن";
                    }
                    break;
                case "Jg":
                    {
                        PlaySounds(WordsClip[109]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "feminine";
                        CodeShow.text = "فومن" + " <color=green>+</color> " + "زنان، جنس زن";
                    }
                    break;
                case "Jh":
                    {
                        PlaySounds(WordsClip[110]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mount";
                        CodeShow.text = "مانتو" + " <color=green>+</color> " + "سوارشدن، صعود کردن";
                    }
                    break;
                case "Ji":
                    {
                        PlaySounds(WordsClip[117]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "victorious";
                        CodeShow.text = "و یک توریست" + " <color=green>+</color> " + "پیروز، فاتح";
                    }
                    break;
                case "Jj":
                    {
                        PlaySounds(WordsClip[118]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "numerous";
                        CodeShow.text = "نام روس" + " <color=green>+</color> " + "بیشمار، بسیار، بزرگ";
                    }
                    break;
                case "Jk":
                    {
                        PlaySounds(WordsClip[119]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "flexible";
                        CodeShow.text = "فلاسک" + " <color=green>+</color> " + "خم شو، قابل انعطاف";
                    }
                    break;
                case "Jl":
                    {
                        PlaySounds(WordsClip[108]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "excel";
                        CodeShow.text = "عکس سیل" + " <color=green>+</color> " + "برتری داشتن، بهتر بودن";
                    }
                    break;
                //Story 11
                case "Ka":
                    {
                        PlaySounds(WordsClip[122]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vision";
                        CodeShow.text = "ویژه" + " <color=green>+</color> " + "قدرت دید، بینایی";
                    }
                    break;
                case "Kb":
                    {
                        PlaySounds(WordsClip[126]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "decade";
                        CodeShow.text = "دهکده" + " <color=green>+</color> " + "ده ساله، دهه";
                    }
                    break;
                case "Kc":
                    {
                        PlaySounds(WordsClip[130]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "minority";
                        CodeShow.text = "مینویی" + " <color=green>+</color> " + "مینیمم، کمترین";
                    }
                    break;
                case "Kd":
                    {
                        PlaySounds(WordsClip[127]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "hesitate";
                        CodeShow.text = "حساسیت" + " <color=green>+</color> " + "دو دل بودن، مردد بودن";
                    }
                    break;
                case "Ke":
                    {
                        PlaySounds(WordsClip[121]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "solitary";
                        CodeShow.text = "سال تاری" + " <color=green>+</color> " + "گوشه نشین،تنها،انفرادی";
                    }
                    break;
                case "Kf":
                    {
                        PlaySounds(WordsClip[123]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "frequent";
                        CodeShow.text = "فری کنترل" + " <color=green>+</color> " + "فراوان،پی در پی،مکرر";
                    }
                    break;
                case "Kg":
                    {
                        PlaySounds(WordsClip[131]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "fiction";
                        CodeShow.text = "فکرشان" + " <color=green>+</color> " + "بی اساس، دروغ، خیال";
                    }
                    break;
                case "Kh":
                    {
                        PlaySounds(WordsClip[129]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "conflict";
                        CodeShow.text = "کافی بود که" + " <color=green>+</color> " + "درگیری، دعوا، مشاجره";
                    }
                    break;
                case "Ki":
                    {
                        PlaySounds(WordsClip[120]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "evidence";
                        CodeShow.text = "یک ویدئو" + " <color=green>+</color> " + "شاهد و مدرک جمع کردن";
                    }
                    break;
                case "Kj":
                    {
                        PlaySounds(WordsClip[125]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "recant";
                        CodeShow.text = "رو کانتینر" + " <color=green>+</color> " + "گفته های خود را تکذیب کردن";
                    }
                    break;
                case "Kk":
                    {
                        PlaySounds(WordsClip[128]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "absurd";
                        CodeShow.text = "آب سرد" + " <color=green>+</color> " + "بی منطقی، پوچ";
                    }
                    break;
                case "Kl":
                    {
                        PlaySounds(WordsClip[124]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "glimpse";
                        CodeShow.text = "گلیم سپس" + " <color=green>+</color> " + "دید،نگاه گذرا،نگاه آنی";
                    }
                    break;
                //Story 12
                case "La":
                    {
                        PlaySounds(WordsClip[139]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prohibit";
                        CodeShow.text = "پرهیبت" + " <color=green>+</color> " + "تحریم، ممنوع کردن";
                    }
                    break;
                case "Lb":
                    {
                        PlaySounds(WordsClip[135]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "population";
                        CodeShow.text = "با پولشان" + " <color=green>+</color> " + "جمعیت";
                    }
                    break;
                case "Lc":
                    {
                        PlaySounds(WordsClip[137]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pollute";
                        CodeShow.text = "پول تو" + " <color=green>+</color> " + "آلوده کردن";
                    }
                    break;
                case "Ld":
                    {
                        PlaySounds(WordsClip[142]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "decrease";
                        CodeShow.text = "دیروز" + " <color=green>+</color> " + "کاهش، کاستن";
                    }
                    break;
                case "Le":
                    {
                        PlaySounds(WordsClip[133]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "abolish";
                        CodeShow.text = "یک بالش" + " <color=green>+</color> " + "منسوخ شدن، برانداختن";
                    }
                    break;
                case "Lf":
                    {
                        PlaySounds(WordsClip[136]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "frank";
                        CodeShow.text = "فرانک" + " <color=green>+</color> " + "رک، صادق";
                    }
                    break;
                case "Lg":
                    {
                        PlaySounds(WordsClip[134]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "urban";
                        CodeShow.text = "اربعین" + " <color=green>+</color> " + "شهری، اهل شهر";
                    }
                    break;
                case "Lh":
                    {
                        PlaySounds(WordsClip[138]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "reveal";
                        CodeShow.text = "روال" + " <color=green>+</color> " + "فاش کردن، آشکار کردن";
                    }
                    break;
                case "Li":
                    {
                        PlaySounds(WordsClip[141]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "adequate";
                        CodeShow.text = "جاده کویت" + " <color=green>+</color> " + "کافی";
                    }
                    break;
                case "Lj":
                    {
                        PlaySounds(WordsClip[143]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "audible";
                        CodeShow.text = "اردبیل" + " <color=green>+</color> " + "شنیدن، رسا، قابل شنیدن";
                    }
                    break;
                case "Lk":
                    {
                        PlaySounds(WordsClip[132]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ignite";
                        CodeShow.text = "اگر نای تو" + " <color=green>+</color> " + "آتش زدن، روشن کردن";
                    }
                    break;
                case "Ll":
                    {
                        PlaySounds(WordsClip[140]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "urgent";
                        CodeShow.text = "اورژانس" + " <color=green>+</color> " + "ضروری، فوری";
                    }
                    break;
                //Story 13
                case "Ma":
                    {
                        PlaySounds(WordsClip[144]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "famine";
                        CodeShow.text = "فامیل" + " <color=green>+</color> " + "کمیابی";
                    }
                    break;
                case "Mb":
                    {
                        PlaySounds(WordsClip[147]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "journalist";
                        CodeShow.text = "جور عالیست" + " <color=green>+</color> " + "روزنامه نگار";
                    }
                    break;
                case "Mc":
                    {
                        PlaySounds(WordsClip[145]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "editor";
                        CodeShow.text = "عده ای طوری" + " <color=green>+</color> " + "ویرایشگر، ویراستار";
                    }
                    break;
                case "Md":
                    {
                        PlaySounds(WordsClip[148]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "commence";
                        CodeShow.text = "کم انسی" + " <color=green>+</color> " + "شروع کردن، آغاز کردن";
                    }
                    break;
                case "Me":
                    {
                        PlaySounds(WordsClip[154]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "migrate";
                        CodeShow.text = "میگیرد" + " <color=green>+</color> " + "مهاجرت کردن";
                    }
                    break;
                case "Mf":
                    {
                        PlaySounds(WordsClip[155]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "identify";
                        CodeShow.text = "ایده نفتی" + " <color=green>+</color> " + "شناسایی کردن، شناختن";
                    }
                    break;
                case "Mg":
                    {
                        PlaySounds(WordsClip[152]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vessel";
                        CodeShow.text = "وصال" + " <color=green>+</color> " + "مجرا،رگ، لوله آوند";
                    }
                    break;
                case "Mh":
                    {
                        PlaySounds(WordsClip[150]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "hazy";
                        CodeShow.text = "هیزی" + " <color=green>+</color> " + "مبهم، نامعلوم";
                    }
                    break;
                case "Mi":
                    {
                        PlaySounds(WordsClip[151]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "persist";
                        CodeShow.text = "پرسید" + " <color=green>+</color> " + "پافشاری،اصرار";
                    }
                    break;
                case "Mj":
                    {
                        PlaySounds(WordsClip[153]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "observant";
                        CodeShow.text = "آب سر وان" + " <color=green>+</color> " + "هوشیار، مراقب";
                    }
                    break;
                case "Mk":
                    {
                        PlaySounds(WordsClip[146]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "revive";
                        CodeShow.text = "دیوار" + " <color=green>+</color> " + "زنده شدن، دوباره روح پیدا کردن";
                    }
                    break;
                case "Ml":
                    {
                        PlaySounds(WordsClip[149]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "gleam";
                        CodeShow.text = "گلیمی" + " <color=green>+</color> " + "سوسو زدن";
                    }
                    break;
                //Story 14
                case "Na":
                    {
                        PlaySounds(WordsClip[167]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "whirling";
                        CodeShow.text = "ول" + " <color=green>+</color> " + "چرخیدن، گرداب";
                    }
                    break;
                case "Nb":
                    {
                        PlaySounds(WordsClip[165]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vicious";
                        CodeShow.text = "وحشی" + " <color=green>+</color> " + "تبهکار، فاسد";
                    }
                    break;
                case "Nc":
                    {
                        PlaySounds(WordsClip[164]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unruly";
                        CodeShow.text = "آن رولی" + " <color=green>+</color> " + "یاغی، سرکش";
                    }
                    break;
                case "Nd":
                    {
                        PlaySounds(WordsClip[160]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "opponent";
                        CodeShow.text = "آب و نان" + " <color=green>+</color> " + "مخالف، ضد";
                    }
                    break;
                case "Ne":
                    {
                        PlaySounds(WordsClip[157]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "brawl";
                        CodeShow.text = "به رول" + " <color=green>+</color> " + "جنجال، دادوبیداد";
                    }
                    break;
                case "Nf":
                    {
                        PlaySounds(WordsClip[161]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rival";
                        CodeShow.text = "را ول" + " <color=green>+</color> " + "حریف، رقیب";
                    }
                    break;
                case "Ng":
                    {
                        PlaySounds(WordsClip[162]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "thrust";
                        CodeShow.text = "سرراست" + " <color=green>+</color> " + "پرت کردن، انداختن";
                    }
                    break;
                case "Nh":
                    {
                        PlaySounds(WordsClip[156]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "bewildered";
                        CodeShow.text = "به ول و درید" + " <color=green>+</color> " + "سردرگم کردن، گیج کردن";
                    }
                    break;
                case "Ni":
                    {
                        PlaySounds(WordsClip[159]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "duplicate";
                        CodeShow.text = "دو پلو کته" + " <color=green>+</color> " + "تکراری، المثنی";
                    }
                    break;
                case "Nj":
                    {
                        PlaySounds(WordsClip[158]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "brutal";
                        CodeShow.text = "برو توله" + " <color=green>+</color> " + "بی رحم، وحشی";
                    }
                    break;
                case "Nk":
                    {
                        PlaySounds(WordsClip[166]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "violent";
                        CodeShow.text = "وای لنت" + " <color=green>+</color> " + "شدید و قوی";
                    }
                    break;
                case "Nl":
                    {
                        PlaySounds(WordsClip[163]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "underdog";
                        CodeShow.text = "آن را در دیگ" + " <color=green>+</color> " + "سگ شکست خورده، توسری خور";
                    }
                    break;
                //Story 15
                case "Oa":
                    {
                        PlaySounds(WordsClip[170]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "expand";
                        CodeShow.text = "عکس پند" + " <color=green>+</color> " + "گسترش یافتن، توسعه دادن";
                    }
                    break;
                case "Ob":
                    {
                        PlaySounds(WordsClip[178]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "sacred";
                        CodeShow.text = "سی کرد" + " <color=green>+</color> " + "خاص، مقدس";
                    }
                    break;
                case "Oc":
                    {
                        PlaySounds(WordsClip[168]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "alter";
                        CodeShow.text = "حالتر" + " <color=green>+</color> " + "تغییر دادن، جابجا کردن";
                    }
                    break;
                case "Od":
                    {
                        PlaySounds(WordsClip[173]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mature";
                        CodeShow.text = "ما جوری" + " <color=green>+</color> " + "رشدکردن، بالغ";
                    }
                    break;
                case "Oe":
                    {
                        PlaySounds(WordsClip[177]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "revise";
                        CodeShow.text = "ریواس" + " <color=green>+</color> " + "اصلاح کردن، تجدیدنظرکردن";
                    }
                    break;
                case "Of":
                    {
                        PlaySounds(WordsClip[175]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pledge";
                        CodeShow.text = "به لج" + " <color=green>+</color> " + "گروگان گرفتن، درگرو، ضمانت";
                    }
                    break;
                case "Og":
                    {
                        PlaySounds(WordsClip[169]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "casual";
                        CodeShow.text = "کجول" + " <color=green>+</color> " + "اتفاقی، تصادفی";
                    }
                    break;
                case "Oh":
                    {
                        PlaySounds(WordsClip[174]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pioneer";
                        CodeShow.text = "پایینی" + " <color=green>+</color> " + "پیشقدم، پیشگام";
                    }
                    break;
                case "Oi":
                    {
                        PlaySounds(WordsClip[179]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unanimous";
                        CodeShow.text = "یونان و مصر" + " <color=green>+</color> " + "همدل و یکسو، هم رای";
                    }
                    break;
                case "Oj":
                    {
                        PlaySounds(WordsClip[176]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pursue";
                        CodeShow.text = "پر سو" + " <color=green>+</color> " + "تعقیب کردن، دنبال کردن";
                    }
                    break;
                case "Ok":
                    {
                        PlaySounds(WordsClip[171]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "fortunate";
                        CodeShow.text = "پر، چون نت" + " <color=green>+</color> " + "خوشحال، خوشبخت";
                    }
                    break;
                case "Ol":
                    {
                        PlaySounds(WordsClip[172]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "innovator";
                        CodeShow.text = "این و تور" + " <color=green>+</color> " + "نوآور، بدعت گذار";
                    }
                    break;
                //Story 16
                case "Pa":
                    {
                        PlaySounds(WordsClip[182]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vast";
                        CodeShow.text = "وسط" + " <color=green>+</color> " + "پهناور، وسیع";
                    }
                    break;
                case "Pb":
                    {
                        PlaySounds(WordsClip[183]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "doubt";
                        CodeShow.text = "دو بت" + " <color=green>+</color> " + "شک و شبهه، تردید";
                    }
                    break;
                case "Pc":
                    {
                        PlaySounds(WordsClip[188]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "microscope";
                        CodeShow.text = "میکروسکوپ" + " <color=green>+</color> " + "ذره بین، ریزبین";
                    }
                    break;
                case "Pd":
                    {
                        PlaySounds(WordsClip[186]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pierce";
                        CodeShow.text = "پرس کرد" + " <color=green>+</color> " + "سوراخ کردن، شکافتن";
                    }
                    break;
                case "Pe":
                    {
                        PlaySounds(WordsClip[187]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "accurate";
                        CodeShow.text = "عه کورید" + " <color=green>+</color> " + "دقت، دقیق، صحیح";
                    }
                    break;
                case "Pf":
                    {
                        PlaySounds(WordsClip[180]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "slender";
                        CodeShow.text = "سیلندر" + " <color=green>+</color> " + "باریک و ضعیف";
                    }
                    break;
                case "Pg":
                    {
                        PlaySounds(WordsClip[185]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "penetrate";
                        CodeShow.text = "پین که ترکید" + " <color=green>+</color> " + "داخل کردن، نفوذ کردن";
                    }
                    break;
                case "Ph":
                    {
                        PlaySounds(WordsClip[184]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "capacity";
                        CodeShow.text = "که پاستیله" + " <color=green>+</color> " + "ظرفیت و گنجایش";
                    }
                    break;
                case "Pi":
                    {
                        PlaySounds(WordsClip[190]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "cautious";
                        CodeShow.text = "کاش یوسف" + " <color=green>+</color> " + "هوشیار و مواظب";
                    }
                    break;
                case "Pj":
                    {
                        PlaySounds(WordsClip[191]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "confident";
                        CodeShow.text = "کناف دینت" + " <color=green>+</color> " + "مطمئن و دلگرم";
                    }
                    break;
                case "Pk":
                    {
                        PlaySounds(WordsClip[181]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "surpass";
                        CodeShow.text = "سور پس" + " <color=green>+</color> " + "فراتر رفتن، پیش افتادن";
                    }
                    break;
                case "Pl":
                    {
                        PlaySounds(WordsClip[189]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "grateful";
                        CodeShow.text = "قرائت فال" + " <color=green>+</color> " + "سپاسگذاری، متشکر";
                    }
                    break;
                //Story 17
                case "Qa":
                    {
                        PlaySounds(WordsClip[201]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "harsh";
                        CodeShow.text = "هر شی" + " <color=green>+</color> " + "درشت و لاغر، زننده";
                    }
                    break;
                case "Qb":
                    {
                        PlaySounds(WordsClip[202]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "quantity";
                        CodeShow.text = "که آن طیف" + " <color=green>+</color> " + "کمیت را معلوم کردن، مقداری";
                    }
                    break;
                case "Qc":
                    {
                        PlaySounds(WordsClip[197]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "avoid";
                        CodeShow.text = "آید" + " <color=green>+</color> " + "اجتناب کردن";
                    }
                    break;
                case "Qd":
                    {
                        PlaySounds(WordsClip[199]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "keg";
                        CodeShow.text = "که چیز" + " <color=green>+</color> " + "چیز ناقابل";
                    }
                    break;
                case "Qe":
                    {
                        PlaySounds(WordsClip[200]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "nourish";
                        CodeShow.text = "نورش" + " <color=green>+</color> " + "قوت دادن";
                    }
                    break;
                case "Qf":
                    {
                        PlaySounds(WordsClip[203]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "opt";
                        CodeShow.text = "آب طالبی" + " <color=green>+</color> " + "انتخاب کردن، برگزیدن";
                    }
                    break;
                case "Qg":
                    {
                        PlaySounds(WordsClip[196]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "misfortune";
                        CodeShow.text = "مس فوری تن" + " <color=green>+</color> " + "بدشانس، بدبخت";
                    }
                    break;
                case "Qh":
                    {
                        PlaySounds(WordsClip[198]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wretched";
                        CodeShow.text = "طوری چید" + " <color=green>+</color> " + "بدبخت، بیچاره";
                    }
                    break;
                case "Qi":
                    {
                        PlaySounds(WordsClip[192]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "appeal";
                        CodeShow.text = "اپل" + " <color=green>+</color> " + "درخواست، التماس";
                    }
                    break;
                case "Qj":
                    {
                        PlaySounds(WordsClip[193]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "addict";
                        CodeShow.text = "عده ای که" + " <color=green>+</color> " + "اعتیاد، معتاد، عادت";
                    }
                    break;
                case "Qk":
                    {
                        PlaySounds(WordsClip[195]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "aware";
                        CodeShow.text = "این وری" + " <color=green>+</color> " + "آگاه";
                    }
                    break;
                case "Ql":
                    {
                        PlaySounds(WordsClip[194]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wary";
                        CodeShow.text = "وری" + " <color=green>+</color> " + "احتیاط، بسیار محتاط";
                    }
                    break;
                //Story 18
                case "Ra":
                    {
                        PlaySounds(WordsClip[212]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rave";
                        CodeShow.text = "ریو" + " <color=green>+</color> " + "دیوانه شدن، جاروجنجال راه انداختن";
                    }
                    break;
                case "Rb":
                    {
                        PlaySounds(WordsClip[210]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "reckless";
                        CodeShow.text = "رک و لوس" + " <color=green>+</color> " + "بی پروا، بی باک، بی ملاحظه";
                    }
                    break;
                case "Rc":
                    {
                        PlaySounds(WordsClip[204]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tragedy";
                        CodeShow.text = "تراژدی" + " <color=green>+</color> " + "تراژدی، نمایش حزن انگیز";
                    }
                    break;
                case "Rd":
                    {
                        PlaySounds(WordsClip[206]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "glance";
                        CodeShow.text = "گران است" + " <color=green>+</color> " + "نگاه سریع، برانداز کردن";
                    }
                    break;
                case "Re":
                    {
                        PlaySounds(WordsClip[209]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "manipulate";
                        CodeShow.text = "مانی پولاتو" + " <color=green>+</color> " + "اداره کردن، دستکاری کردن";
                    }
                    break;
                case "Rf":
                    {
                        PlaySounds(WordsClip[205]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pedestrian";
                        CodeShow.text = "پیداست ژیان" + " <color=green>+</color> " + "پیاده، وابسته به پیاده روی";
                    }
                    break;
                case "Rg":
                    {
                        PlaySounds(WordsClip[208]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "nimble";
                        CodeShow.text = "نیم بیل" + " <color=green>+</color> " + "زرنگ، چست و چابک";
                    }
                    break;
                case "Rh":
                    {
                        PlaySounds(WordsClip[207]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "budget";
                        CodeShow.text = "بادگیر" + " <color=green>+</color> " + "بودجه";
                    }
                    break;
                case "Ri":
                    {
                        PlaySounds(WordsClip[214]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "lubricate";
                        CodeShow.text = "لو بری کته" + " <color=green>+</color> " + "لیزکردن، چرب کردن";
                    }
                    break;
                case "Rj":
                    {
                        PlaySounds(WordsClip[211]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "horrid";
                        CodeShow.text = "هارید" + " <color=green>+</color> " + "وحشتناک، ترسناک";
                    }
                    break;
                case "Rk":
                    {
                        PlaySounds(WordsClip[215]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ingenious";
                        CodeShow.text = "این جنی است" + " <color=green>+</color> " + "مخترع، دارای قوه ابتکار";
                    }
                    break;
                case "Rl":
                    {
                        PlaySounds(WordsClip[213]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "economical";
                        CodeShow.text = "نکونامی کلا" + " <color=green>+</color> " + "مقرون به صرفه، اقتصادی";
                    }
                    break;
                //Story 19
                case "Sa":
                    {
                        PlaySounds(WordsClip[216]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "harvest";
                        CodeShow.text = "هار است" + " <color=green>+</color> " + "نتیجه، محصول";
                    }
                    break;
                case "Sb":
                    {
                        PlaySounds(WordsClip[218]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "uneasy";
                        CodeShow.text = "انیسی" + " <color=green>+</color> " + "مضطرب و پریشان";
                    }
                    break;
                case "Sc":
                    {
                        PlaySounds(WordsClip[225]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ban";
                        CodeShow.text = "بنی" + " <color=green>+</color> " + "قدغن، بازداشتن، ممنوع کردن";
                    }
                    break;
                case "Sd":
                    {
                        PlaySounds(WordsClip[217]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "abundant";
                        CodeShow.text = "ابا ندارد" + " <color=green>+</color> " + "بسیار، فراوان، وافر";
                    }
                    break;
                case "Se":
                    {
                        PlaySounds(WordsClip[219]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "calculate";
                        CodeShow.text = "کل کل هایشان" + " <color=green>+</color> " + "حساب کردن";
                    }
                    break;
                case "Sf":
                    {
                        PlaySounds(WordsClip[224]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "threat";
                        CodeShow.text = "تریت" + " <color=green>+</color> " + "تهدید، تهدید کردن";
                    }
                    break;
                case "Sg":
                    {
                        PlaySounds(WordsClip[227]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "appropriate";
                        CodeShow.text = "آبروی پریست که" + " <color=green>+</color> " + "اختصاص دادن، برای خود برداشتن";
                    }
                    break;
                case "Sh":
                    {
                        PlaySounds(WordsClip[220]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "absorb";
                        CodeShow.text = "آب زوری" + " <color=green>+</color> " + "جذب کردن، فروبردن،جذاب";
                    }
                    break;
                case "Si":
                    {
                        PlaySounds(WordsClip[221]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "estimate";
                        CodeShow.text = "ایست موتور" + " <color=green>+</color> " + "ارزیابی کردن، تخمین زدن";
                    }
                    break;
                case "Sj":
                    {
                        PlaySounds(WordsClip[223]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "quota";
                        CodeShow.text = "کو تا" + " <color=green>+</color> " + "سهم، سهمیه";
                    }
                    break;
                case "Sk":
                    {
                        PlaySounds(WordsClip[226]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "panic";
                        CodeShow.text = "پنکه" + " <color=green>+</color> " + "وحشت، ترس،اضطراب";
                    }
                    break;
                case "Sl":
                    {
                        PlaySounds(WordsClip[222]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "morsel";
                        CodeShow.text = "مرسل" + " <color=green>+</color> " + "یک لقمه غذا، لقمه، تکه";
                    }
                    break;
                //Story 20
                case "Ta":
                    {
                        PlaySounds(WordsClip[236]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "fragile";
                        CodeShow.text = "فر آجیل" + " <color=green>+</color> " + "شکننده، ترد و نازک";
                    }
                    break;
                case "Tb":
                    {
                        PlaySounds(WordsClip[229]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "jagged";
                        CodeShow.text = "جا قید" + " <color=green>+</color> " + "دندانه دار، ناهموار";
                    }
                    break;
                case "Tc":
                    {
                        PlaySounds(WordsClip[231]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ambush";
                        CodeShow.text = "آن موشی" + " <color=green>+</color> " + "کمین کردن";
                    }
                    break;
                case "Td":
                    {
                        PlaySounds(WordsClip[230]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "linger";
                        CodeShow.text = "لنگر" + " <color=green>+</color> " + "درنگ کردن، مردد، منتظر ماندن";
                    }
                    break;
                case "Te":
                    {
                        PlaySounds(WordsClip[232]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "crafty";
                        CodeShow.text = "کر آفتی" + " <color=green>+</color> " + "حیله گر، فریبنده، بامهارت";
                    }
                    break;
                case "Tf":
                    {
                        PlaySounds(WordsClip[237]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "captive";
                        CodeShow.text = "کاپوت" + " <color=green>+</color> " + "گرفتار، اسیر";
                    }
                    break;
                case "Tg":
                    {
                        PlaySounds(WordsClip[233]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "defiant";
                        CodeShow.text = "دفاع" + " <color=green>+</color> " + "جسور و مبارز";
                    }
                    break;
                case "Th":
                    {
                        PlaySounds(WordsClip[234]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vigor";
                        CodeShow.text = "فیگور" + " <color=green>+</color> " + "قدرت، نیرو";
                    }
                    break;
                case "Ti":
                    {
                        PlaySounds(WordsClip[235]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "perish";
                        CodeShow.text = "پرش" + " <color=green>+</color> " + "هلاک شدن، مردن";
                    }
                    break;
                case "Tj":
                    {
                        PlaySounds(WordsClip[228]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "emerge";
                        CodeShow.text = "هرج و مرج" + " <color=green>+</color> " + "پدیدار شدن، بیرون آمدن";
                    }
                    break;
                case "Tk":
                    {
                        PlaySounds(WordsClip[238]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prosper";
                        CodeShow.text = "پر و سپر" + " <color=green>+</color> " + "پریشان کننده";
                    }
                    break;
                case "Tl":
                    {
                        PlaySounds(WordsClip[239]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "devour";
                        CodeShow.text = "دیوار" + " <color=green>+</color> " + "بلعیدن، حریصانه خوردن";
                    }
                    break;
                //Story 21
                case "Ua":
                    {
                        PlaySounds(WordsClip[249]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "transmit";
                        CodeShow.text = "ترانس می توانست" + " <color=green>+</color> " + "انتقال دادن، عبوردادن";
                    }
                    break;
                case "Ub":
                    {
                        PlaySounds(WordsClip[250]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "relive";
                        CodeShow.text = "ریلی و" + " <color=green>+</color> " + "تسکین، کاهش دادن از بین بردن";
                    }
                    break;
                case "Uc":
                    {
                        PlaySounds(WordsClip[240]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "plea";
                        CodeShow.text = "پولی" + " <color=green>+</color> " + "درخواست";
                    }
                    break;
                case "Ud":
                    {
                        PlaySounds(WordsClip[251]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "baffle";
                        CodeShow.text = "با فعل" + " <color=green>+</color> " + "گمراه کردن، گیج کردن";
                    }
                    break;
                case "Ue":
                    {
                        PlaySounds(WordsClip[241]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "weary";
                        CodeShow.text = "وری" + " <color=green>+</color> " + "خسته و بیزار، کسل شدن";
                    }
                    break;
                case "Uf":
                    {
                        PlaySounds(WordsClip[244]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "verify";
                        CodeShow.text = "وری فی ها" + " <color=green>+</color> " + "وارسی کردن، بازبینی کردن";
                    }
                    break;
                case "Ug":
                    {
                        PlaySounds(WordsClip[245]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "anticipate";
                        CodeShow.text = "آن طی سی پک" + " <color=green>+</color> " + "پیش بینی کردن";
                    }
                    break;
                case "Uh":
                    {
                        PlaySounds(WordsClip[246]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "dilemma";
                        CodeShow.text = "دل ما" + " <color=green>+</color> " + "وضعیت دشوار";
                    }
                    break;
                case "Ui":
                    {
                        PlaySounds(WordsClip[242]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "collide";
                        CodeShow.text = "کل باید" + " <color=green>+</color> " + "بهم خوردن، تصادف کردن";
                    }
                    break;
                case "Uj":
                    {
                        PlaySounds(WordsClip[247]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "detour";
                        CodeShow.text = "دی تور" + " <color=green>+</color> " + "انحراف، منحرف شدن";
                    }
                    break;
                case "Uk":
                    {
                        PlaySounds(WordsClip[248]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "merit";
                        CodeShow.text = "مریت" + " <color=green>+</color> " + "سزاوار،شایستگی،لیاقت";
                    }
                    break;
                case "Ul":
                    {
                        PlaySounds(WordsClip[243]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "confirm";
                        CodeShow.text = "که آن فرم" + " <color=green>+</color> " + "تایید کردن، تصدیق کردن";
                    }
                    break;
                //Story 22
                case "Va":
                    {
                        PlaySounds(WordsClip[259]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unstable";
                        CodeShow.text = "آن اصطبل" + " <color=green>+</color> " + "لرزان، بی پایه";
                    }
                    break;
                case "Vb":
                    {
                        PlaySounds(WordsClip[257]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "spouse";
                        CodeShow.text = "سپاس" + " <color=green>+</color> " + "همسر، زن یا شوهر";
                    }
                    break;
                case "Vc":
                    {
                        PlaySounds(WordsClip[252]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "warden";
                        CodeShow.text = "وردنه" + " <color=green>+</color> " + "نگهبان، سرپرست، ناظر";
                    }
                    break;
                case "Vd":
                    {
                        PlaySounds(WordsClip[255]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "delinquent";
                        CodeShow.text = "دلیر کنت" + " <color=green>+</color> " + "متخلف، مرتکب جنایت";
                    }
                    break;
                case "Ve":
                    {
                        PlaySounds(WordsClip[256]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "deprive";
                        CodeShow.text = "دید پریوش" + " <color=green>+</color> " + "محروم کردن، بی بهره کردن";
                    }
                    break;
                case "Vf":
                    {
                        PlaySounds(WordsClip[253]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "acknowledge";
                        CodeShow.text = "اکنون لج کرده" + " <color=green>+</color> " + "تایید کردن، تصدیق کردن";
                    }
                    break;
                case "Vg":
                    {
                        PlaySounds(WordsClip[254]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "justice";
                        CodeShow.text = "جاست که" + " <color=green>+</color> " + "عدالت،انصاف";
                    }
                    break;
                case "Vh":
                    {
                        PlaySounds(WordsClip[263]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "reject";
                        CodeShow.text = "ریژک" + " <color=green>+</color> " + "رد کردن، نپذیرفتن";
                    }
                    break;
                case "Vi":
                    {
                        PlaySounds(WordsClip[261]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "penalize";
                        CodeShow.text = "پینه لایه زیر" + " <color=green>+</color> " + "تاوان، جریمه";
                    }
                    break;
                case "Vj":
                    {
                        PlaySounds(WordsClip[260]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "homicide";
                        CodeShow.text = "حامی سایت" + " <color=green>+</color> " + "قتل، آدم کشی";
                    }
                    break;
                case "Vk":
                    {
                        PlaySounds(WordsClip[258]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vocation";
                        CodeShow.text = "وکیشن" + " <color=green>+</color> " + "کسب و کار، شغل";
                    }
                    break;
                case "Vl":
                    {
                        PlaySounds(WordsClip[262]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "beneficiary";
                        CodeShow.text = "بنفشه ای" + " <color=green>+</color> " + "بهره بردار، ذینفع";
                    }
                    break;
                //Story 23
                case "Wa":
                    {
                        PlaySounds(WordsClip[271]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "embrace";
                        CodeShow.text = "انبردست" + " <color=green>+</color> " + "درآغوش گرفتن،آغوش، بغل کردن";
                    }
                    break;
                case "Wb":
                    {
                        PlaySounds(WordsClip[264]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "reptile";
                        CodeShow.text = "ریپ که طایل" + " <color=green>+</color> " + "حیوان خزنده، آدم پست";
                    }
                    break;
                case "Wc":
                    {
                        PlaySounds(WordsClip[265]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rarely";
                        CodeShow.text = "ریلی" + " <color=green>+</color> " + "به ندرت، خیلی کم";
                    }
                    break;
                case "Wd":
                    {
                        PlaySounds(WordsClip[275]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "logical";
                        CodeShow.text = "حلاجی کار" + " <color=green>+</color> " + "منطقی";
                    }
                    break;
                case "We":
                    {
                        PlaySounds(WordsClip[274]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "forbid";
                        CodeShow.text = "فربد" + " <color=green>+</color> " + "ممنوع کردن، اجازه ندادن";
                    }
                    break;
                case "Wf":
                    {
                        PlaySounds(WordsClip[270]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prior";
                        CodeShow.text = "پیرارسال" + " <color=green>+</color> " + "پیشتاز،اولی، مقدم";
                    }
                    break;
                case "Wg":
                    {
                        PlaySounds(WordsClip[266]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "exhibit";
                        CodeShow.text = "عکس بیتی" + " <color=green>+</color> " + "در معرض  نمایش گذاشتن";
                    }
                    break;
                case "Wh":
                    {
                        PlaySounds(WordsClip[267]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "proceed";
                        CodeShow.text = "پرسید" + " <color=green>+</color> " + "پیش رفتن،حرکت کردن";
                    }
                    break;
                case "Wi":
                    {
                        PlaySounds(WordsClip[268]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "precaution";
                        CodeShow.text = "پر گشودن" + " <color=green>+</color> " + "احتیاط کردن، پیشبینی کردن";
                    }
                    break;
                case "Wj":
                    {
                        PlaySounds(WordsClip[273]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "partial";
                        CodeShow.text = "پارسال" + " <color=green>+</color> " + "طرفدار،علاقه مند";
                    }
                    break;
                case "Wk":
                    {
                        PlaySounds(WordsClip[269]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "extract";
                        CodeShow.text = "عکس تراکت" + " <color=green>+</color> " + "استخراج کردن، خارج کردن";
                    }
                    break;
                case "Wl":
                    {
                        PlaySounds(WordsClip[272]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "valiant";
                        CodeShow.text = "والی نت" + " <color=green>+</color> " + "شجاع، دلاور";
                    }
                    break;
                //Story 24
                case "Xa":
                    {
                        PlaySounds(WordsClip[283]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wail";
                        CodeShow.text = "ویل" + " <color=green>+</color> " + "ناله و شیون، ماتم گرفتن";
                    }
                    break;
                case "Xb":
                    {
                        PlaySounds(WordsClip[282]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vermin";
                        CodeShow.text = "ور، مین" + " <color=green>+</color> " + "آفت، جانور";
                    }
                    break;
                case "Xc":
                    {
                        PlaySounds(WordsClip[276]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "fierce";
                        CodeShow.text = "فی ارث" + " <color=green>+</color> " + "حریص، درنده، خشم آلود";
                    }
                    break;
                case "Xd":
                    {
                        PlaySounds(WordsClip[287]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "trifle";
                        CodeShow.text = "تو را فعلا" + " <color=green>+</color> " + "ناچیز، کم بها";
                    }
                    break;
                case "Xe":
                    {
                        PlaySounds(WordsClip[278]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "sneer";
                        CodeShow.text = "اسیر" + " <color=green>+</color> " + "تمسخر، پوزخند زدن";
                    }
                    break;
                case "Xf":
                    {
                        PlaySounds(WordsClip[277]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "detest";
                        CodeShow.text = "دیده است" + " <color=green>+</color> " + "بیزاربودن، تنفرداشتن";
                    }
                    break;
                case "Xg":
                    {
                        PlaySounds(WordsClip[284]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "symbol";
                        CodeShow.text = "سمبل" + " <color=green>+</color> " + "نشانه و علامت";
                    }
                    break;
                case "Xh":
                    {
                        PlaySounds(WordsClip[279]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "scowl";
                        CodeShow.text = "اسکل" + " <color=green>+</color> " + "ترش رویی، اخم کردن";
                    }
                    break;
                case "Xi":
                    {
                        PlaySounds(WordsClip[285]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "authority";
                        CodeShow.text = "او تاریکی" + " <color=green>+</color> " + "اجازه، اختیار";
                    }
                    break;
                case "Xj":
                    {
                        PlaySounds(WordsClip[286]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "neutral";
                        CodeShow.text = "نیتش را" + " <color=green>+</color> " + "خنثی، بی طرف";
                    }
                    break;
                case "Xk":
                    {
                        PlaySounds(WordsClip[280]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "encourage";
                        CodeShow.text = "این کور اگر" + " <color=green>+</color> " + "تشویق کردن، دلگرم مردن";
                    }
                    break;
                case "Xl":
                    {
                        PlaySounds(WordsClip[281]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "consider";
                        CodeShow.text = "که آن سی در" + " <color=green>+</color> " + "تفکر کردن، ملاحظه کردن";
                    }
                    break;
                //Story 25
                case "Ya":
                    {
                        PlaySounds(WordsClip[297]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "bigamy";
                        CodeShow.text = "بی غمیه" + " <color=green>+</color> " + "دو زن داری";
                    }
                    break;
                case "Yb":
                    {
                        PlaySounds(WordsClip[299]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "architect";
                        CodeShow.text = "عار که نیست" + " <color=green>+</color> " + "معمار، معماری کردن";
                    }
                    break;
                case "Yc":
                    {
                        PlaySounds(WordsClip[288]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "matrimony";
                        CodeShow.text = "مات منی" + " <color=green>+</color> " + "ازدواج، نکاح";
                    }
                    break;
                case "Yd":
                    {
                        PlaySounds(WordsClip[290]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "squander";
                        CodeShow.text = "اسکندر" + " <color=green>+</color> " + "ولخرج، تلف کردن،اسراف کردن";
                    }
                    break;
                case "Ye":
                    {
                        PlaySounds(WordsClip[294]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pauper";
                        CodeShow.text = "پول پر" + " <color=green>+</color> " + "گدا، بینوا";
                    }
                    break;
                case "Yf":
                    {
                        PlaySounds(WordsClip[298]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "collapse";
                        CodeShow.text = "کلا پس از" + " <color=green>+</color> " + "متلاشی شدن، فروپاشی";
                    }
                    break;
                case "Yg":
                    {
                        PlaySounds(WordsClip[293]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "calamity";
                        CodeShow.text = "کلام تو" + " <color=green>+</color> " + "بلا، فاجعه،مصیبت";
                    }
                    break;
                case "Yh":
                    {
                        PlaySounds(WordsClip[296]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prosecute";
                        CodeShow.text = "پروسه ای که" + " <color=green>+</color> " + "تحت تعقیب، دنبال کردن";
                    }
                    break;
                case "Yi":
                    {
                        PlaySounds(WordsClip[289]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "baggage";
                        CodeShow.text = "با گیجی" + " <color=green>+</color> " + "بار سفر، باروبنه";
                    }
                    break;
                case "Yj":
                    {
                        PlaySounds(WordsClip[291]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "abroad";
                        CodeShow.text = "عیب رود" + " <color=green>+</color> " + "خارج،وسیع";
                    }
                    break;
                case "Yk":
                    {
                        PlaySounds(WordsClip[295]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "envy";
                        CodeShow.text = "این وری" + " <color=green>+</color> " + "حسادت، رشک";
                    }
                    break;
                case "Yl":
                    {
                        PlaySounds(WordsClip[292]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "fugitive";
                        CodeShow.text = "فوجی، تیو" + " <color=green>+</color> " + "تبعیدی، فراری";
                    }
                    break;
                //Story 26
                case "Za":
                    {
                        PlaySounds(WordsClip[303]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "venture";
                        CodeShow.text = "فنچی" + " <color=green>+</color> " + "جرات، جسارت، مخاطره";
                    }
                    break;
                case "Zb":
                    {
                        PlaySounds(WordsClip[304]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "awesome";
                        CodeShow.text = "او سم" + " <color=green>+</color> " + "وحشت آور، حرمت، هیبت";
                    }
                    break;
                case "Zc":
                    {
                        PlaySounds(WordsClip[310]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "respond ";
                        CodeShow.text = "رئیس باند" + " <color=green>+</color> " + "واکنش نشان دادن، پاسخ دادن";
                    }
                    break;
                case "Zd":
                    {
                        PlaySounds(WordsClip[302]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "awkward";
                        CodeShow.text = "او که ورد" + " <color=green>+</color> " + "ناشی، خامکار، بی دست و پا";
                    }
                    break;
                case "Ze":
                    {
                        PlaySounds(WordsClip[300]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "possible";
                        CodeShow.text = "پای سیبل" + " <color=green>+</color> " + "امکان دارد، مقدور";
                    }
                    break;
                case "Zf":
                    {
                        PlaySounds(WordsClip[305]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "guide";
                        CodeShow.text = "قید" + " <color=green>+</color> " + "راهنمایی، راهنمایی کردن";
                    }
                    break;
                case "Zg":
                    {
                        PlaySounds(WordsClip[308]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "utter";
                        CodeShow.text = "عاتر" + " <color=green>+</color> " + "به زبان آوردن، گفتن";
                    }
                    break;
                case "Zh":
                    {
                        PlaySounds(WordsClip[301]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "compel";
                        CodeShow.text = "کم پول" + " <color=green>+</color> " + "وادار کردن، مجبور کردن";
                    }
                    break;
                case "Zi":
                    {
                        PlaySounds(WordsClip[306]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "quench";
                        CodeShow.text = "که فنچ" + " <color=green>+</color> " + "دفع کردن، فرونشاندن";
                    }
                    break;
                case "Zj":
                    {
                        PlaySounds(WordsClip[307]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "betray";
                        CodeShow.text = "بهتری" + " <color=green>+</color> " + "خیانت کردن، فاش کردن";
                    }
                    break;
                case "Zk":
                    {
                        PlaySounds(WordsClip[311]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "beckon";
                        CodeShow.text = "بکن" + " <color=green>+</color> " + "اشاره کردن با دست و صدا زدن";
                    }
                    break;
                case "Zl":
                    {
                        PlaySounds(WordsClip[309]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pacify";
                        CodeShow.text = "پاس فی" + " <color=green>+</color> " + "آرام کردن، تسکین دادن";
                    }
                    break;
                //Story 27
                case "AAa":
                    {
                        PlaySounds(WordsClip[315]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rapid";
                        CodeShow.text = "را پیدا" + " <color=green>+</color> " + "سریع، تند";
                    }
                    break;
                case "AAb":
                    {
                        PlaySounds(WordsClip[316]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "exhaust";
                        CodeShow.text = "عکس اوست" + " <color=green>+</color> " + "خسته کردن، اگزوز";
                    }
                    break;
                case "AAc":
                    {
                        PlaySounds(WordsClip[318]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "feeble";
                        CodeShow.text = "فیبر" + " <color=green>+</color> " + "کم زور، ضعیف";
                    }
                    break;
                case "AAd":
                    {
                        PlaySounds(WordsClip[323]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "monarch";
                        CodeShow.text = "منا را که" + " <color=green>+</color> " + "ملکه، پادشاه";
                    }
                    break;
                case "AAe":
                    {
                        PlaySounds(WordsClip[319]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unite";
                        CodeShow.text = "یون هایت" + " <color=green>+</color> " + "متحد کردن، متصل شدن";
                    }
                    break;
                case "AAf":
                    {
                        PlaySounds(WordsClip[317]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "severity";
                        CodeShow.text = "سوری تو" + " <color=green>+</color> " + "سختی، خشونت، شدت";
                    }
                    break;
                case "AAg":
                    {
                        PlaySounds(WordsClip[322]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "miserly";
                        CodeShow.text = "ما یه ذره" + " <color=green>+</color> " + "خسیس، چشم تنگ";
                    }
                    break;
                case "AAh":
                    {
                        PlaySounds(WordsClip[321]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "thrifty";
                        CodeShow.text = "سررفتی" + " <color=green>+</color> " + "صرفه جویی";
                    }
                    break;
                case "AAi":
                    {
                        PlaySounds(WordsClip[320]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "cease";
                        CodeShow.text = "سوسیس" + " <color=green>+</color> " + "دست کشیدن، متوقف شدن";
                    }
                    break;
                case "AAj":
                    {
                        PlaySounds(WordsClip[314]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rash";
                        CodeShow.text = "برایش" + " <color=green>+</color> " + "بی پروا،عجول،تند";
                    }
                    break;
                case "AAk":
                    {
                        PlaySounds(WordsClip[312]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "despite";
                        CodeShow.text = "دیسک پایت" + " <color=green>+</color> " + "بااینکه، باوجود";
                    }
                    break;
                case "AAl":
                    {
                        PlaySounds(WordsClip[313]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "disrupt";
                        CodeShow.text = "دیس ریخت" + " <color=green>+</color> " + "مختل کردن، درهم گسیختن";
                    }
                    break;
                //Story 28
                case "BBa":
                    {
                        PlaySounds(WordsClip[334]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "bait";
                        CodeShow.text = "بیت" + " <color=green>+</color> " + "خوراک دادن، طعمه دادن";
                    }
                    break;
                case "BBb":
                    {
                        PlaySounds(WordsClip[335]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "insist";
                        CodeShow.text = "این سیستم" + " <color=green>+</color> " + "اصرار کردن، پافشاری کردن";
                    }
                    break;
                case "BBc":
                    {
                        PlaySounds(WordsClip[327]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "illustrate";
                        CodeShow.text = "ایل استراحت" + " <color=green>+</color> " + "نشان دادن، توضیح دادن";
                    }
                    break;
                case "BBd":
                    {
                        PlaySounds(WordsClip[324]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "outlaw";
                        CodeShow.text = "او تلو تلو" + " <color=green>+</color> " + "قانون شکن، یاغی،غیر قانونی";
                    }
                    break;
                case "BBe":
                    {
                        PlaySounds(WordsClip[331]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "censor";
                        CodeShow.text = "سنسور" + " <color=green>+</color> " + "سانسورکردن";
                    }
                    break;
                case "BBf":
                    {
                        PlaySounds(WordsClip[326]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "undernourished";
                        CodeShow.text = "آن در نور خورشید" + " <color=green>+</color> " + "سوء تغذیه";
                    }
                    break;
                case "BBg":
                    {
                        PlaySounds(WordsClip[333]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "juvenile";
                        CodeShow.text = "جیوه، نای" + " <color=green>+</color> " + "جوان، نوجوان";
                    }
                    break;
                case "BBh":
                    {
                        PlaySounds(WordsClip[330]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "disaster";
                        CodeShow.text = "دیزی آستر" + " <color=green>+</color> " + "بلا، مصیبت، بدبختی";
                    }
                    break;
                case "BBi":
                    {
                        PlaySounds(WordsClip[329]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "excessive";
                        CodeShow.text = "عکس سه سیب" + " <color=green>+</color> " + "بیش از اندازه، مفرط";
                    }
                    break;
                case "BBj":
                    {
                        PlaySounds(WordsClip[332]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "culprit";
                        CodeShow.text = "کال، پری" + " <color=green>+</color> " + "خطاکار، مقصر، مجرم";
                    }
                    break;
                case "BBk":
                    {
                        PlaySounds(WordsClip[325]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "promote";
                        CodeShow.text = "پری مرد" + " <color=green>+</color> " + "ترفیع دادن، ترقی دادن";
                    }
                    break;
                case "BBl":
                    {
                        PlaySounds(WordsClip[328]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "disclose";
                        CodeShow.text = "دیس که لوز" + " <color=green>+</color> " + "فاش کردن، آشکارکردن";
                    }
                    break;
                //Story 29
                case "CCa":
                    {
                        PlaySounds(WordsClip[340]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "subside";
                        CodeShow.text = "سوبسید" + " <color=green>+</color> " + "پایین آمدن، فروکش کردن";
                    }
                    break;
                case "CCb":
                    {
                        PlaySounds(WordsClip[345]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "exempt";
                        CodeShow.text = "عکس و مپ" + " <color=green>+</color> " + "معاف کردن، معاف،آزاد";
                    }
                    break;
                case "CCc":
                    {
                        PlaySounds(WordsClip[338]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "daze";
                        CodeShow.text = "دیز" + " <color=green>+</color> " + "مبهوت، خیرگی، گیج کردن";
                    }
                    break;
                case "CCd":
                    {
                        PlaySounds(WordsClip[336]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "toil";
                        CodeShow.text = "تو یل" + " <color=green>+</color> " + "رنج، مشقت، زحمت کشیدن";
                    }
                    break;
                case "CCe":
                    {
                        PlaySounds(WordsClip[342]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "comprehend";
                        CodeShow.text = "کم پیراهن" + " <color=green>+</color> " + "دریافتن، فهمیدن";
                    }
                    break;
                case "CCf":
                    {
                        PlaySounds(WordsClip[339]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mourn";
                        CodeShow.text = "موری اند" + " <color=green>+</color> " + "گریه کردن، عزاداری کردن";
                    }
                    break;
                case "CCg":
                    {
                        PlaySounds(WordsClip[341]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "maim";
                        CodeShow.text = "ماییم" + " <color=green>+</color> " + "صدمه زدن،آسیب";
                    }
                    break;
                case "CCh":
                    {
                        PlaySounds(WordsClip[346]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vain";
                        CodeShow.text = "و این" + " <color=green>+</color> " + "بیهوده، عبث، بی فایده";
                    }
                    break;
                case "CCi":
                    {
                        PlaySounds(WordsClip[337]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "blunder";
                        CodeShow.text = "بلان در" + " <color=green>+</color> " + "اشتباه بزرگ";
                    }
                    break;
                case "CCj":
                    {
                        PlaySounds(WordsClip[343]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "commend";
                        CodeShow.text = "کمند" + " <color=green>+</color> " + "ستایش کردن، ستودن";
                    }
                    break;
                case "CCk":
                    {
                        PlaySounds(WordsClip[347]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "repetition";
                        CodeShow.text = "ریپیتشان" + " <color=green>+</color> " + "تکرار، باز، انجام";
                    }
                    break;
                case "CCl":
                    {
                        PlaySounds(WordsClip[344]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "final";
                        CodeShow.text = "فینال" + " <color=green>+</color> " + "تعیین کننده، پایانی";
                    }
                    break;
                //Story 30
                case "DDa":
                    {
                        PlaySounds(WordsClip[358]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "roam";
                        CodeShow.text = "روم" + " <color=green>+</color> " + "پرسه زدن، تکاپو، گشتن";
                    }
                    break;
                case "DDb":
                    {
                        PlaySounds(WordsClip[359]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "attract";
                        CodeShow.text = "یک تراکتی" + " <color=green>+</color> " + "جذب کردن";
                    }
                    break;
                case "DDc":
                    {
                        PlaySounds(WordsClip[350]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "novel";
                        CodeShow.text = "نوول" + " <color=green>+</color> " + "جدید، نو";
                    }
                    break;
                case "DDd":
                    {
                        PlaySounds(WordsClip[349]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mortal";
                        CodeShow.text = "مور طالع" + " <color=green>+</color> " + "فانی، از بین رونده";
                    }
                    break;
                case "DDe":
                    {
                        PlaySounds(WordsClip[357]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "morality";
                        CodeShow.text = "مور عالی ترین" + " <color=green>+</color> " + "اخلاق";
                    }
                    break;
                case "DDf":
                    {
                        PlaySounds(WordsClip[351]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "occupant";
                        CodeShow.text = "آکبند" + " <color=green>+</color> " + "مستاجر، ساکن";
                    }
                    break;
                case "DDg":
                    {
                        PlaySounds(WordsClip[354]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "site";
                        CodeShow.text = "سایت" + " <color=green>+</color> " + "موقعیت، جا، مکان";
                    }
                    break;
                case "DDh":
                    {
                        PlaySounds(WordsClip[353]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "quarter";
                        CodeShow.text = "کوتری" + " <color=green>+</color> " + "یک چهارم، پناه گرفتن";
                    }
                    break;
                case "DDi":
                    {
                        PlaySounds(WordsClip[356]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "verse";
                        CodeShow.text = "و ارث" + " <color=green>+</color> " + "به نظم درآوردن، اشعار";
                    }
                    break;
                case "DDj":
                    {
                        PlaySounds(WordsClip[348]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "depict";
                        CodeShow.text = "دیشب پاکتی" + " <color=green>+</color> " + "نمایش دادن به وسیله طرح و نقشه";
                    }
                    break;
                case "DDk":
                    {
                        PlaySounds(WordsClip[352]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "appoint";
                        CodeShow.text = "دپو اینترنتی" + " <color=green>+</color> " + "انتخاب کردن، تعیین کردن";
                    }
                    break;
                case "DDl":
                    {
                        PlaySounds(WordsClip[355]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "quote";
                        CodeShow.text = "کوت" + " <color=green>+</color> " + "ایراد گرفتن، نقل قول کردن";
                    }
                    break;
                //Story 31
                case "EEa":
                    {
                        PlaySounds(WordsClip[360]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "commuter";
                        CodeShow.text = "کمی آن طرف تر" + " <color=green>+</color> " + "رفت و آمد، مسافری";
                    }
                    break;
                case "EEb":
                    {
                        PlaySounds(WordsClip[371]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "fertile";
                        CodeShow.text = "فر طایل" + " <color=green>+</color> " + "بابرکت، پربار، پرثمر";
                    }
                    break;
                case "EEc":
                    {
                        PlaySounds(WordsClip[364]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "jest";
                        CodeShow.text = "ژست" + " <color=green>+</color> " + "مسخره، خنده دار";
                    }
                    break;
                case "EEd":
                    {
                        PlaySounds(WordsClip[362]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "idle";
                        CodeShow.text = "آی دل" + " <color=green>+</color> " + "تنبل، بیکار";
                    }
                    break;
                case "EEe":
                    {
                        PlaySounds(WordsClip[363]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "idol";
                        CodeShow.text = "آی دل" + " <color=green>+</color> " + "بت";
                    }
                    break;
                case "EEf":
                    {
                        PlaySounds(WordsClip[367]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "valor";
                        CodeShow.text = "والور" + " <color=green>+</color> " + "شجاع";
                    }
                    break;
                case "EEg":
                    {
                        PlaySounds(WordsClip[366]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "dispute";
                        CodeShow.text = "دیس پوت" + " <color=green>+</color> " + "بحث ، انکار کردن";
                    }
                    break;
                case "EEh":
                    {
                        PlaySounds(WordsClip[370]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "uneventful";
                        CodeShow.text = "آن وانت فول" + " <color=green>+</color> " + "بی تفاوت، بدون حادثه";
                    }
                    break;
                case "EEi":
                    {
                        PlaySounds(WordsClip[369]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vein";
                        CodeShow.text = "و این" + " <color=green>+</color> " + "خلق وخو، روش، رگ";
                    }
                    break;
                case "EEj":
                    {
                        PlaySounds(WordsClip[368]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "lunatic";
                        CodeShow.text = "لونده، تیک" + " <color=green>+</color> " + "دیوانه، مجنون";
                    }
                    break;
                case "EEk":
                    {
                        PlaySounds(WordsClip[361]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "confine";
                        CodeShow.text = "که این و آن را" + " <color=green>+</color> " + "محدود کردن، محدوده";
                    }
                    break;
                case "EEl":
                    {
                        PlaySounds(WordsClip[365]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "patriotic";
                        CodeShow.text = "پیت ریخت" + " <color=green>+</color> " + "میهن پرستی";
                    }
                    break;
                //Story 32
                case "FFa":
                    {
                        PlaySounds(WordsClip[373]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "distress";
                        CodeShow.text = "استرس" + " <color=green>+</color> " + "ناراحتی، پریشانی، اندوه";
                    }
                    break;
                case "FFb":
                    {
                        PlaySounds(WordsClip[374]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "diminish";
                        CodeShow.text = "دامنش" + " <color=green>+</color> " + "کم شدن، نقصان یافتن";
                    }
                    break;
                case "FFc":
                    {
                        PlaySounds(WordsClip[375]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "maximum";
                        CodeShow.text = "ماکسیمم" + " <color=green>+</color> " + "حداکثر، بیشترین مقدار";
                    }
                    break;
                case "FFd":
                    {
                        PlaySounds(WordsClip[379]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mythology";
                        CodeShow.text = "مثل اوج" + " <color=green>+</color> " + "اساطیر،افسانه شناسی";
                    }
                    break;
                case "FFe":
                    {
                        PlaySounds(WordsClip[376]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "flee";
                        CodeShow.text = "فله ای" + " <color=green>+</color> " + "متواری شدن، فرار کردن";
                    }
                    break;
                case "FFf":
                    {
                        PlaySounds(WordsClip[372]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "refer";
                        CodeShow.text = "ریف اگر" + " <color=green>+</color> " + "مراجعه کردن، فرستادن";
                    }
                    break;
                case "FFg":
                    {
                        PlaySounds(WordsClip[377]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vulnerable";
                        CodeShow.text = "وانی ربل" + " <color=green>+</color> " + "آسیب پذیر، قابل حمله";
                    }
                    break;
                case "FFh":
                    {
                        PlaySounds(WordsClip[378]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "signify";
                        CodeShow.text = "سگ نفایه" + " <color=green>+</color> " + "نشان دادن";
                    }
                    break;
                case "FFi":
                    {
                        PlaySounds(WordsClip[383]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "loyalty";
                        CodeShow.text = "ولو علتی" + " <color=green>+</color> " + "وفادار، باوفا";
                    }
                    break;
                case "FFj":
                    {
                        PlaySounds(WordsClip[380]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "colleague";
                        CodeShow.text = "کالی اگر" + " <color=green>+</color> " + "همکار، همراه";
                    }
                    break;
                case "FFk":
                    {
                        PlaySounds(WordsClip[381]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "torment ";
                        CodeShow.text = "تور،منت" + " <color=green>+</color> " + "شکنجه، عذاب، رنج";
                    }
                    break;
                case "FFl":
                    {
                        PlaySounds(WordsClip[382]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "provide";
                        CodeShow.text = "پرو آید" + " <color=green>+</color> " + "آماده کردن،فراهم کردن";
                    }
                    break;
                //Story 33
                case "GGa":
                    {
                        PlaySounds(WordsClip[394]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wad";
                        CodeShow.text = "وادی" + " <color=green>+</color> " + "توده، بقچه";
                    }
                    break;
                case "GGb":
                    {
                        PlaySounds(WordsClip[386]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "shrill";
                        CodeShow.text = "شر ایلی" + " <color=green>+</color> " + "گوشخراش، تندوتیز";
                    }
                    break;
                case "GGc":
                    {
                        PlaySounds(WordsClip[393]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mute";
                        CodeShow.text = "میو تا" + " <color=green>+</color> " + "ساکت، بیصدا، لال";
                    }
                    break;
                case "GGd":
                    {
                        PlaySounds(WordsClip[384]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "volunteer";
                        CodeShow.text = "والن، تیر" + " <color=green>+</color> " + "داوطلب، خواستار";
                    }
                    break;
                case "GGe":
                    {
                        PlaySounds(WordsClip[385]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prejudice";
                        CodeShow.text = "پره جداست" + " <color=green>+</color> " + "تبعیض کردن، ضرر، تعصب";
                    }
                    break;
                case "GGf":
                    {
                        PlaySounds(WordsClip[387]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "jolly";
                        CodeShow.text = "جالی" + " <color=green>+</color> " + "سرزنده، خوشی، لذت بردن";
                    }
                    break;
                case "GGg":
                    {
                        PlaySounds(WordsClip[390]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "lecture";
                        CodeShow.text = "لک چرا" + " <color=green>+</color> " + "سخنرانی کردن";
                    }
                    break;
                case "GGh":
                    {
                        PlaySounds(WordsClip[392]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "mumble";
                        CodeShow.text = "منبل" + " <color=green>+</color> " + "مسخره کردن، زیرلب سخن گفتن";
                    }
                    break;
                case "GGi":
                    {
                        PlaySounds(WordsClip[391]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "abuse";
                        CodeShow.text = "آب است" + " <color=green>+</color> " + "سوء استفاده کردن";
                    }
                    break;
                case "GGj":
                    {
                        PlaySounds(WordsClip[388]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "witty";
                        CodeShow.text = "کویتی" + " <color=green>+</color> " + "شوخ طبع، بذله گو";
                    }
                    break;
                case "GGk":
                    {
                        PlaySounds(WordsClip[389]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "hinder";
                        CodeShow.text = " هندی را" + " <color=green>+</color> " + "به تاخیر انداختن، عقبی";
                    }
                    break;
                case "GGl":
                    {
                        PlaySounds(WordsClip[395]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "retain";
                        CodeShow.text = "را طین" + " <color=green>+</color> " + "حفظ کردن، نگه داشتن،استخدام";
                    }
                    break;
                //Story 34
                case "HHa":
                    {
                        PlaySounds(WordsClip[401]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "spontaneous";
                        CodeShow.text = "اسبان طینوث" + " <color=green>+</color> " + "بطورطبیعی، خود به خود";
                    }
                    break;
                case "HHb":
                    {
                        PlaySounds(WordsClip[397]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "precede";
                        CodeShow.text = "پرسید که" + " <color=green>+</color> " + "جلوتر بودن، مقدم بودن";
                    }
                    break;
                case "HHc":
                    {
                        PlaySounds(WordsClip[396]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "candidate";
                        CodeShow.text = "کاندیدها" + " <color=green>+</color> " + "کاندید، داوطلب، نامزدانتخاباتی";
                    }
                    break;
                case "HHd":
                    {
                        PlaySounds(WordsClip[407]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "temperate";
                        CodeShow.text = "تم پیرش" + " <color=green>+</color> " + "معتدل، ملایم";
                    }
                    break;
                case "HHe":
                    {
                        PlaySounds(WordsClip[400]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "radical";
                        CodeShow.text = "رادیکالی" + " <color=green>+</color> " + "افراطی، رادیکال";
                    }
                    break;
                case "HHf":
                    {
                        PlaySounds(WordsClip[406]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "sensitive";
                        CodeShow.text = "سن ستی و" + " <color=green>+</color> " + "حساس";
                    }
                    break;
                case "HHg":
                    {
                        PlaySounds(WordsClip[404]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "untidy";
                        CodeShow.text = "آن تاییدی" + " <color=green>+</color> " + "ناخوشایند، درهم برهم";
                    }
                    break;
                case "HHh":
                    {
                        PlaySounds(WordsClip[402]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "skim";
                        CodeShow.text = "سکم" + " <color=green>+</color> " + "تماس اندک، به طور سطحی خواندن";
                    }
                    break;
                case "HHi":
                    {
                        PlaySounds(WordsClip[403]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vaccinate";
                        CodeShow.text = "واکسن هایتان" + " <color=green>+</color> " + "واکسینه کردن،واکسن زدن";
                    }
                    break;
                case "HHj":
                    {
                        PlaySounds(WordsClip[398]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "adolescent";
                        CodeShow.text = "عادل هستند" + " <color=green>+</color> " + "بزرگ سالی، بالغ";
                    }
                    break;
                case "HHk":
                    {
                        PlaySounds(WordsClip[399]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "coeducational";
                        CodeShow.text = "کو این جوک آشنا" + " <color=green>+</color> " + "مختلط";
                    }
                    break;
                case "HHl":
                    {
                        PlaySounds(WordsClip[405]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "utensil";
                        CodeShow.text = "او تنسیل" + " <color=green>+</color> " + "وسایل، ظرف";
                    }
                    break;
                //Story 35
                case "IIa":
                    {
                        PlaySounds(WordsClip[417]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "subsequent";
                        CodeShow.text = "سابی، سکونت" + " <color=green>+</color> " + "مابعد";
                    }
                    break;
                case "IIb":
                    {
                        PlaySounds(WordsClip[418]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "relate";
                        CodeShow.text = "ریلیت" + " <color=green>+</color> " + "گفتن، گزارش دادن، بازگو کردن";
                    }
                    break;
                case "IIc":
                    {
                        PlaySounds(WordsClip[414]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "event";
                        CodeShow.text = "ایوانت" + " <color=green>+</color> " + "واقعه،حادثه";
                    }
                    break;
                case "IId":
                    {
                        PlaySounds(WordsClip[415]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "discard";
                        CodeShow.text = "دیس، کارد" + " <color=green>+</color> " + "ول کردن، ترک کردن";
                    }
                    break;
                case "IIe":
                    {
                        PlaySounds(WordsClip[419]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "stationary";
                        CodeShow.text = "استیشن آری" + " <color=green>+</color> " + "بی حرکت، ساکن،ایستاده";
                    }
                    break;
                case "IIf":
                    {
                        PlaySounds(WordsClip[410]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "lottery";
                        CodeShow.text = "لات ری" + " <color=green>+</color> " + "قرعه کشی، بخت آزمایی";
                    }
                    break;
                case "IIg":
                    {
                        PlaySounds(WordsClip[408]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vague";
                        CodeShow.text = "واگو" + " <color=green>+</color> " + "نامشخص و مبهم نامفهوم";
                    }
                    break;
                case "IIh":
                    {
                        PlaySounds(WordsClip[409]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "elevate";
                        CodeShow.text = "اولویت" + " <color=green>+</color> " + "بالابردن، ترفیع دادن";
                    }
                    break;
                case "IIi":
                    {
                        PlaySounds(WordsClip[411]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "finance";
                        CodeShow.text = "پای نان که" + " <color=green>+</color> " + "سرمایه گذاری، مالیه، دارایی";
                    }
                    break;
                case "IIj":
                    {
                        PlaySounds(WordsClip[416]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "soar";
                        CodeShow.text = "سور" + " <color=green>+</color> " + "بلندپروازی، اوج گرفتن";
                    }
                    break;
                case "IIk":
                    {
                        PlaySounds(WordsClip[412]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "obtain";
                        CodeShow.text = "آب تنی" + " <color=green>+</color> " + "فراهم کردن، بدست آوردن";
                    }
                    break;
                case "IIl":
                    {
                        PlaySounds(WordsClip[413]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "cinema";
                        CodeShow.text = "سی نما" + " <color=green>+</color> " + "سینما، تصویرمتحرک";
                    }
                    break;
                //Story 36
                case "JJa":
                    {
                        PlaySounds(WordsClip[430]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "illegal";
                        CodeShow.text = "ائل گلی" + " <color=green>+</color> " + "خلاف قانون،غیر قانونی";
                    }
                    break;
                case "JJb":
                    {
                        PlaySounds(WordsClip[423]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tempest";
                        CodeShow.text = "تم پست" + " <color=green>+</color> " + "آشفتگی، طوفان، تندباد";
                    }
                    break;
                case "JJc":
                    {
                        PlaySounds(WordsClip[427]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "resume";
                        CodeShow.text = "ریزوم" + " <color=green>+</color> " + "ادامه دادن، ازسرگرفتن";
                    }
                    break;
                case "JJd":
                    {
                        PlaySounds(WordsClip[428]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "harmony";
                        CodeShow.text = "هارمونی" + " <color=green>+</color> " + "هماهنگی، تطبیق، توازن";
                    }
                    break;
                case "JJe":
                    {
                        PlaySounds(WordsClip[420]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "prompt";
                        CodeShow.text = "پرآمپر" + " <color=green>+</color> " + "سریع، فوری، بیدرنگ";
                    }
                    break;
                case "JJf":
                    {
                        PlaySounds(WordsClip[421]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "hasty";
                        CodeShow.text = "هستی" + " <color=green>+</color> " + "سریع، عجول، شتابزده";
                    }
                    break;
                case "JJg":
                    {
                        PlaySounds(WordsClip[429]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "refrain";
                        CodeShow.text = "نفرین" + " <color=green>+</color> " + "خوددداری کردن، منع کردن";
                    }
                    break;
                case "JJh":
                    {
                        PlaySounds(WordsClip[425]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "sympathetic";
                        CodeShow.text = "سیم و پاستیل" + " <color=green>+</color> " + "همدرد، دلسوز";
                    }
                    break;
                case "JJi":
                    {
                        PlaySounds(WordsClip[431]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "narcotic";
                        CodeShow.text = "نار، کتی که" + " <color=green>+</color> " + "مخدر، مسکن";
                    }
                    break;
                case "JJj":
                    {
                        PlaySounds(WordsClip[424]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "soothe";
                        CodeShow.text = "سوت" + " <color=green>+</color> " + "آرام کردن، دلجویی کردن";
                    }
                    break;
                case "JJk":
                    {
                        PlaySounds(WordsClip[426]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "redeem";
                        CodeShow.text = "ریدیم" + " <color=green>+</color> " + "جبران کردن، رهایی دادن";
                    }
                    break;
                case "JJl":
                    {
                        PlaySounds(WordsClip[422]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "scorch";
                        CodeShow.text = "اسکورتی" + " <color=green>+</color> " + "بودادن، سوختگی";
                    }
                    break;
                //Story 37
                case "KKa":
                    {
                        PlaySounds(WordsClip[432]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "heir";
                        CodeShow.text = "هر" + " <color=green>+</color> " + "وارث، ارث، میراث";
                    }
                    break;
                case "KKb":
                    {
                        PlaySounds(WordsClip[443]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "heed";
                        CodeShow.text = "هید" + " <color=green>+</color> " + "توجه، مراقبت، نگه داری";
                    }
                    break;
                case "KKc":
                    {
                        PlaySounds(WordsClip[439]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "drought";
                        CodeShow.text = "درایت" + " <color=green>+</color> " + "خشکسالی";
                    }
                    break;
                case "KKd":
                    {
                        PlaySounds(WordsClip[435]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "surplus";
                        CodeShow.text = "سر پلیس" + " <color=green>+</color> " + "مازاد، اضافه";
                    }
                    break;
                case "KKe":
                    {
                        PlaySounds(WordsClip[442]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "summit";
                        CodeShow.text = "سامیت" + " <color=green>+</color> " + "بالاترین نقطه،اوج";
                    }
                    break;
                case "KKf":
                    {
                        PlaySounds(WordsClip[433]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "majestic";
                        CodeShow.text = "ما جستی که" + " <color=green>+</color> " + "باشکوه،باعظمت، بزرگ";
                    }
                    break;
                case "KKg":
                    {
                        PlaySounds(WordsClip[437]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "deliberate";
                        CodeShow.text = "دلی برات" + " <color=green>+</color> " + "حساب شده،اندیشه کردن،عمدی";
                    }
                    break;
                case "KKh":
                    {
                        PlaySounds(WordsClip[438]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vandal";
                        CodeShow.text = "و آن دل" + " <color=green>+</color> " + "خرابکار، خرابگر";
                    }
                    break;
                case "KKi":
                    {
                        PlaySounds(WordsClip[434]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "dwindle";
                        CodeShow.text = "دوی این دلت" + " <color=green>+</color> " + "تحلیل رفتن، کاهش پیدا کردن، کم شدن";
                    }
                    break;
                case "KKj":
                    {
                        PlaySounds(WordsClip[436]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "traitor";
                        CodeShow.text = "ترا تور" + " <color=green>+</color> " + "خیانتکار، خائن";
                    }
                    break;
                case "KKk":
                    {
                        PlaySounds(WordsClip[440]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "abide";
                        CodeShow.text = "نباید" + " <color=green>+</color> " + "تحمل کردن،ایستادگی کردن";
                    }
                    break;
                case "KKl":
                    {
                        PlaySounds(WordsClip[441]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unify";
                        CodeShow.text = "یونی وار" + " <color=green>+</color> " + "متحد ساختن، یکی شدن";
                    }
                    break;
                //Story 38
                case "LLa":
                    {
                        PlaySounds(WordsClip[444]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "biography";
                        CodeShow.text = "با یک گرافیک" + " <color=green>+</color> " + "زندگی نامه";
                    }
                    break;
                case "LLb":
                    {
                        PlaySounds(WordsClip[445]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "drench";
                        CodeShow.text = "درنک" + " <color=green>+</color> " + "آب دادن، خیس کردن";
                    }
                    break;
                case "LLc":
                    {
                        PlaySounds(WordsClip[447]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wobble";
                        CodeShow.text = "وابل" + " <color=green>+</color> " + "تکان خوردن، تلوتلو خوردن";
                    }
                    break;
                case "LLd":
                    {
                        PlaySounds(WordsClip[448]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tumult";
                        CodeShow.text = "توی ملت" + " <color=green>+</color> " + "آشفتگی،همهمه،غوغا";
                    }
                    break;
                case "LLe":
                    {
                        PlaySounds(WordsClip[446]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "swarm";
                        CodeShow.text = "سوارم" + " <color=green>+</color> " + "گروه،دسته،ازدحام";
                    }
                    break;
                case "LLf":
                    {
                        PlaySounds(WordsClip[449]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "kneel";
                        CodeShow.text = "نیل" + " <color=green>+</color> " + "زانو زدن";
                    }
                    break;
                case "LLg":
                    {
                        PlaySounds(WordsClip[450]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "dejected";
                        CodeShow.text = "دجی که له" + " <color=green>+</color> " + "غمگین،افسرده،محزون";
                    }
                    break;
                case "LLh":
                    {
                        PlaySounds(WordsClip[451]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "obedient";
                        CodeShow.text = "او به دینت" + " <color=green>+</color> " + "مطیع، فرمانبردار";
                    }
                    break;
                case "LLi":
                    {
                        PlaySounds(WordsClip[453]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "tyrant";
                        CodeShow.text = "تا یک رانت" + " <color=green>+</color> " + "حاکم ستمگر، زورگو";
                    }
                    break;
                case "LLj":
                    {
                        PlaySounds(WordsClip[452]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "recede";
                        CodeShow.text = "رسید" + " <color=green>+</color> " + "عقب نشینی کردن، خودداری کردن";
                    }
                    break;
                case "LLk":
                    {
                        PlaySounds(WordsClip[455]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "verdict";
                        CodeShow.text = "ور دیکته" + " <color=green>+</color> " + "حکم،رای،نظر";
                    }
                    break;
                case "LLl":
                    {
                        PlaySounds(WordsClip[454]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "charity";
                        CodeShow.text = "چاره تو" + " <color=green>+</color> " + "گذشت، خیرات، صدقه";
                    }
                    break;
                //Story 39
                case "MMa":
                    {
                        PlaySounds(WordsClip[459]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "cancel";
                        CodeShow.text = "که آن سیل" + " <color=green>+</color> " + "خنثی کردن،باطل کردن";
                    }
                    break;
                case "MMb":
                    {
                        PlaySounds(WordsClip[464]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "clergy";
                        CodeShow.text = "کولرچی" + " <color=green>+</color> " + "روحانی،دیندار،روحانیون";
                    }
                    break;
                case "MMc":
                    {
                        PlaySounds(WordsClip[460]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "debtor";
                        CodeShow.text = "دختر" + " <color=green>+</color> " + "مدیون، بدهکار";
                    }
                    break;
                case "MMd":
                    {
                        PlaySounds(WordsClip[461]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "legible";
                        CodeShow.text = "لجی، بله" + " <color=green>+</color> " + "روشن، خوانا";
                    }
                    break;
                case "MMe":
                    {
                        PlaySounds(WordsClip[458]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "coincide";
                        CodeShow.text = "کو این صاید" + " <color=green>+</color> " + "مصادف شدن، همزمان بودن";
                    }
                    break;
                case "MMf":
                    {
                        PlaySounds(WordsClip[462]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "placard";
                        CodeShow.text = "پلاکارد" + " <color=green>+</color> " + "پلاکارد،پوستر";
                    }
                    break;
                case "MMg":
                    {
                        PlaySounds(WordsClip[463]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "contagious";
                        CodeShow.text = "که این تگیست" + " <color=green>+</color> " + "واگیردار، واگیر";
                    }
                    break;
                case "MMh":
                    {
                        PlaySounds(WordsClip[467]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "scald";
                        CodeShow.text = "سکالید" + " <color=green>+</color> " + "با بخار داغ سوزاندن";
                    }
                    break;
                case "MMi":
                    {
                        PlaySounds(WordsClip[465]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "customary";
                        CodeShow.text = "کاست تا مری" + " <color=green>+</color> " + "عادی، مرسوم";
                    }
                    break;
                case "MMj":
                    {
                        PlaySounds(WordsClip[466]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "transparent";
                        CodeShow.text = "تو را نسپارنت" + " <color=green>+</color> " + "پیدا،واضح،شفاف";
                    }
                    break;
                case "MMk":
                    {
                        PlaySounds(WordsClip[457]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "depart";
                        CodeShow.text = "دپارتمان" + " <color=green>+</color> " + "دور شدن، راهی شدن";
                    }
                    break;
                case "MMl":
                    {
                        PlaySounds(WordsClip[456]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "unearth";
                        CodeShow.text = "آن ارث" + " <color=green>+</color> " + "پی بردن، از خاک بیرون کشیدن";
                    }
                    break;
                //Story 40
                case "NNa":
                    {
                        PlaySounds(WordsClip[468]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "epidemic";
                        CodeShow.text = "اپیدمیک" + " <color=green>+</color> " + "همه گیر، واگیر";
                    }
                    break;
                case "NNb":
                    {
                        PlaySounds(WordsClip[470]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "magnify";
                        CodeShow.text = "مگر نفی" + " <color=green>+</color> " + "بزرگنمایی";
                    }
                    break;
                case "NNc":
                    {
                        PlaySounds(WordsClip[469]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "obesity";
                        CodeShow.text = "آبی و صورتی" + " <color=green>+</color> " + "چاقی مفرط، فربهی";
                    }
                    break;
                case "NNd":
                    {
                        PlaySounds(WordsClip[471]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "chiropractor";
                        CodeShow.text = "کار با تراکتور" + " <color=green>+</color> " + "طبیب مفصل، فن ماساژ";
                    }
                    break;
                case "NNe":
                    {
                        PlaySounds(WordsClip[478]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "municipal";
                        CodeShow.text = "میان سه پل" + " <color=green>+</color> " + "شهری،وابسته به شهرداری";
                    }
                    break;
                case "NNf":
                    {
                        PlaySounds(WordsClip[472]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "obstacle";
                        CodeShow.text = "آب است تا کله" + " <color=green>+</color> " + "گیر، پاگیر، سد راه";
                    }
                    break;
                case "NNg":
                    {
                        PlaySounds(WordsClip[473]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ventilate";
                        CodeShow.text = "و این تیلر" + " <color=green>+</color> " + "تهویه کردن، بادخور کردن";
                    }
                    break;
                case "NNh":
                    {
                        PlaySounds(WordsClip[474]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "jeopardize";
                        CodeShow.text = "جوپرداز" + " <color=green>+</color> " + "به خطر انداختن";
                    }
                    break;
                case "NNi":
                    {
                        PlaySounds(WordsClip[479]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "oral";
                        CodeShow.text = "او را لکنت" + " <color=green>+</color> " + "زبانی، شفاهی";
                    }
                    break;
                case "NNj":
                    {
                        PlaySounds(WordsClip[475]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "negative";
                        CodeShow.text = "نگاه تو" + " <color=green>+</color> " + "منفی";
                    }
                    break;
                case "NNk":
                    {
                        PlaySounds(WordsClip[476]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "pension";
                        CodeShow.text = "پیشین" + " <color=green>+</color> " + "حقوق بازنشستگی";
                    }
                    break;
                case "NNl":
                    {
                        PlaySounds(WordsClip[477]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vital";
                        CodeShow.text = "وای تل" + " <color=green>+</color> " + "ضروری، حیاتی";
                    }
                    break;
                //Story 41
                case "OOa":
                    {
                        PlaySounds(WordsClip[488]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "morgue";
                        CodeShow.text = "مرغ" + " <color=green>+</color> " + "سردخانه، مرده خانه";
                    }
                    break;
                case "OOb":
                    {
                        PlaySounds(WordsClip[484]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "vertical";
                        CodeShow.text = "ورد کال" + " <color=green>+</color> " + "عمودی";
                    }
                    break;
                case "OOc":
                    {
                        PlaySounds(WordsClip[483]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "parole";
                        CodeShow.text = "پاترول" + " <color=green>+</color> " + "آزادی موقت، قول مردانه";
                    }
                    break;
                case "OOd":
                    {
                        PlaySounds(WordsClip[486]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "nominate";
                        CodeShow.text = "ناامیدت" + " <color=green>+</color> " + " نامزد کردن، نامیدن";
                    }
                    break;
                case "OOe":
                    {
                        PlaySounds(WordsClip[487]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "potential";
                        CodeShow.text = "پوتین و شال" + " <color=green>+</color> " + "توانایی، پتانسیل";
                    }
                    break;
                case "OOf":
                    {
                        PlaySounds(WordsClip[491]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "indifference";
                        CodeShow.text = "این دیفرانسیل" + " <color=green>+</color> " + "بی توجه، بی تفاوت";
                    }
                    break;
                case "OOg":
                    {
                        PlaySounds(WordsClip[480]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "complacent";
                        CodeShow.text = "کیم پلاسند" + " <color=green>+</color> " + "ازخود راضی، خود خواه";
                    }
                    break;
                case "OOh":
                    {
                        PlaySounds(WordsClip[490]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "upholstery";
                        CodeShow.text = "آب خالص تری" + " <color=green>+</color> " + "اثاث";
                    }
                    break;
                case "OOi":
                    {
                        PlaySounds(WordsClip[481]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wasp";
                        CodeShow.text = "واسه پول" + " <color=green>+</color> " + "زنبور";
                    }
                    break;
                case "OOj":
                    {
                        PlaySounds(WordsClip[489]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "preoccupied";
                        CodeShow.text = "پر اوکه پایید" + " <color=green>+</color> " + "دل مشغول، گرفتار، پریشان";
                    }
                    break;
                case "OOk":
                    {
                        PlaySounds(WordsClip[485]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "multitude";
                        CodeShow.text = "مالتی تو ده" + " <color=green>+</color> " + "تعداد زیاد، جمعیت";
                    }
                    break;
                case "OOl":
                    {
                        PlaySounds(WordsClip[482]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "rehabilitate";
                        CodeShow.text = "را بی لیته" + " <color=green>+</color> " + "احیاکردن، توانبخشی کردن";
                    }
                    break;
                //Story 42
                case "PPa":
                    {
                        PlaySounds(WordsClip[492]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "maintain";
                        CodeShow.text = "دومین طین" + " <color=green>+</color> " + "حمایت، حفظ کردن";
                    }
                    break;
                case "PPb":
                    {
                        PlaySounds(WordsClip[493]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "snub";
                        CodeShow.text = "اصناف" + " <color=green>+</color> " + "سرزنش کردن، جلوگیری";
                    }
                    break;
                case "PPc":
                    {
                        PlaySounds(WordsClip[495]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wrath";
                        CodeShow.text = "راس" + " <color=green>+</color> " + "خشم،خشمگین،ناراحت";
                    }
                    break;
                case "PPd":
                    {
                        PlaySounds(WordsClip[502]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "amend";
                        CodeShow.text = "همند" + " <color=green>+</color> " + "تغییردادن،اصلاح کردن";
                    }
                    break;
                case "PPe":
                    {
                        PlaySounds(WordsClip[498]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ponder";
                        CodeShow.text = "پان در" + " <color=green>+</color> " + "اندیشیدن، فکر کردن";
                    }
                    break;
                case "PPf":
                    {
                        PlaySounds(WordsClip[497]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "legend";
                        CodeShow.text = "لجند" + " <color=green>+</color> " + "داستان،افسانه";
                    }
                    break;
                case "PPg":
                    {
                        PlaySounds(WordsClip[500]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "drastic";
                        CodeShow.text = "دراز تیک" + " <color=green>+</color> " + "شدید،قوی،موثر";
                    }
                    break;
                case "PPh":
                    {
                        PlaySounds(WordsClip[499]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "resign";
                        CodeShow.text = "ریزان" + " <color=green>+</color> " + "واگذارکردن،دست کشیدن";
                    }
                    break;
                case "PPi":
                    {
                        PlaySounds(WordsClip[494]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "endure";
                        CodeShow.text = "این دوره" + " <color=green>+</color> " + "متحمل شدن، تحمل کردن";
                    }
                    break;
                case "PPj":
                    {
                        PlaySounds(WordsClip[501]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "wharf";
                        CodeShow.text = "و عرف" + " <color=green>+</color> " + "اسکله، لنگرگاه";
                    }
                    break;
                case "PPk":
                    {
                        PlaySounds(WordsClip[503]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "ballot";
                        CodeShow.text = "بالت" + " <color=green>+</color> " + "رای";
                    }
                    break;
                case "PPl":
                    {
                        PlaySounds(WordsClip[496]);
                        PanelShowWords.gameObject.SetActive(true);
                        WordsShow.text = "expose";
                        CodeShow.text = "عکس پوز" + " <color=green>+</color> " + "نمایش دادن،افشاکردن";
                    }
                    break;
            }
        }
    }
}
