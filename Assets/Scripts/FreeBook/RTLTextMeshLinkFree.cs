using UnityEngine;
using UnityEngine.EventSystems;
using RTLTMPro;
using TMPro;

public class RTLTextMeshLinkFree : MonoBehaviour, IPointerClickHandler
{
    RTLTextMeshPro rtltextMeshProFree;
    Canvas canvasRTL;
    Camera _cameraRTL;
    public GameObject PanelShowWordsFree;
    public RTLTextMeshPro CodeShowFree;
    public TextMeshProUGUI WordsShowFree;
    public AudioSource audioSourceFree;
    public AudioClip[] WordsClipFree;
    

    void Awake()
    {
        rtltextMeshProFree = gameObject.GetComponent<RTLTextMeshPro>();
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
        audioSourceFree.PlayOneShot(sound);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(rtltextMeshProFree, Input.mousePosition, _cameraRTL);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = rtltextMeshProFree.textInfo.linkInfo[linkIndex];
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
                        PlaySounds(WordsClipFree[0]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "abandon";
                        CodeShowFree.text = "آبادان" + " <color=green>+</color> " + "ترک کردن، رها کردن";
                    }
                    break;
                case "Ab":
                    {
                        PlaySounds(WordsClipFree[1]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "unaccustomed";
                        CodeShowFree.text = "آن عکاس امید" + " <color=green>+</color> " + "غیر عادی";
                    }
                    break;
                case "Ac":
                    {
                        PlaySounds(WordsClipFree[2]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "bachelor";
                        CodeShowFree.text = "بچه لر" + " <color=green>+</color> " + "مجرد، لیسانس";
                    }
                    break;
                case "Ad":
                    {
                        PlaySounds(WordsClipFree[3]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "jealous";
                        CodeShowFree.text = "ژله داشت" + " <color=green>+</color> " + "حسود، حسادت آمیز";
                    }
                    break;
                case "Ae":
                    {
                        PlaySounds(WordsClipFree[4]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "gallant";
                        CodeShowFree.text = "گیلانی" + " <color=green>+</color> " + "شجاع، دلیر";
                    }
                    break;
                case "Af":
                    {
                        PlaySounds(WordsClipFree[5]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "tact";
                        CodeShowFree.text = "تک تیرانداز" + " <color=green>+</color> " + "مهارت، سلیقه";
                    }
                    break;
                case "Ag":
                    {
                        PlaySounds(WordsClipFree[6]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "oath";
                        CodeShowFree.text = "استاد" + " <color=green>+</color> " + "قسم خوردن، سوگند";
                    }
                    break;
                case "Ah":
                    {
                        PlaySounds(WordsClipFree[7]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "keen";
                        CodeShowFree.text = "کینه ای" + " <color=green>+</color> " + "حساس، قوی";
                    }
                    break;
                case "Ai":
                    {
                        PlaySounds(WordsClipFree[8]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "qualify";
                        CodeShowFree.text = "کجا را علی فرمانده" + " <color=green>+</color> " + "تعیین کردن";
                    }
                    break;
                case "Aj":
                    {
                        PlaySounds(WordsClipFree[9]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "data";
                        CodeShowFree.text = "ده تا" + " <color=green>+</color> " + "اطلاعات، شواهد";
                    }
                    break;
                case "Ak":
                    {
                        PlaySounds(WordsClipFree[10]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "vacant";
                        CodeShowFree.text = "و کانتینر" + " <color=green>+</color> " + "خالی، بیکار";
                    }
                    break;
                case "Al":
                    {
                        PlaySounds(WordsClipFree[11]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "hardship";
                        CodeShowFree.text = "هر شیب" + " <color=green>+</color> " + "سختی، مشقت";
                    }
                    break;
                //Story 2
                case "Ba":
                    {
                        PlaySounds(WordsClipFree[12]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "frigid";
                        CodeShowFree.text = "فریزر" + " <color=green>+</color> " + "بسیار سرد، منجمد";
                    }
                    break;
                case "Bb":
                    {
                        PlaySounds(WordsClipFree[13]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "numb";
                        CodeShowFree.text = "نامه بر" + " <color=green>+</color> " + "بی حس، کرخت";
                    }
                    break;
                case "Bc":
                    {
                        PlaySounds(WordsClipFree[14]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "inhabit";
                        CodeShowFree.text = "این ها بیت" + " <color=green>+</color> " + "ساکن شدن";
                    }
                    break;
                case "Bd":
                    {
                        PlaySounds(WordsClipFree[15]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "tempt";
                        CodeShowFree.text = "تمپیت" + " <color=green>+</color> " + "هوس کردن، وسوسه شدن";
                    }
                    break;
                case "Be":
                    {
                        PlaySounds(WordsClipFree[16]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "wager";
                        CodeShowFree.text = "واگیر" + " <color=green>+</color> " + "شرط بندی، شرط بستن";
                    }
                    break;
                case "Bf":
                    {
                        PlaySounds(WordsClipFree[17]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "peril";
                        CodeShowFree.text = "پریل" + " <color=green>+</color> " + "به خطر انداختن، خطر";
                    }
                    break;
                case "Bg":
                    {
                        PlaySounds(WordsClipFree[18]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "shriek";
                        CodeShowFree.text = "شریک" + " <color=green>+</color> " + "فریاد، جیغ";
                    }
                    break;
                case "Bh":
                    {
                        PlaySounds(WordsClipFree[19]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "sinister";
                        CodeShowFree.text = "سینی ستاره دار" + " <color=green>+</color> " + "گمراه کننده، نادرست";
                    }
                    break;
                case "Bi":
                    {
                        PlaySounds(WordsClipFree[20]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "corpse";
                        CodeShowFree.text = "کور مثل" + " <color=green>+</color> " + "جسد، جنازه";
                    }
                    break;
                case "Bj":
                    {
                        PlaySounds(WordsClipFree[21]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "recline";
                        CodeShowFree.text = "روی یک لاین" + " <color=green>+</color> " + "دراز کشیدن";
                    }
                    break;
                case "Bk":
                    {
                        PlaySounds(WordsClipFree[22]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "dismal";
                        CodeShowFree.text = "دستمال" + " <color=green>+</color> " + "پریشان کننده";
                    }
                    break;
                case "Bl":
                    {
                        PlaySounds(WordsClipFree[23]);
                        PanelShowWordsFree.gameObject.SetActive(true);
                        WordsShowFree.text = "conceal";
                        CodeShowFree.text = "که آن سیل" + " <color=green>+</color> " + "پنهان کردن، پوشاندن";
                    }
                    break;
            }
        }
    }
}