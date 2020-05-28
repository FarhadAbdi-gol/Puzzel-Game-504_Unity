using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using RTLTMPro;
using TMPro;
using System;
using UnityEngine.Networking;
using CodeStage.AntiCheat.Storage;


public class FaryarDataBase : MonoBehaviour
{
    #region Public Variables
    public InputField InputYourRef;
    public RTLTextMeshPro MessageBoxCheckRef, MessageBoxCreate;

    public Text CodeUserPass, TextPassword;
    public InputField InputPassword, InputEmailwithPass;
    public RTLTextMeshPro MessageBoxPass;

    public InputField InputCodeUserLogin, InputPasswordLogin;
    public RTLTextMeshPro MessageBoxLogin;

    public InputField InputCodeUserRecovery, InputEmailRecovery;
    public RTLTextMeshPro MessageBoxRecovery;

    public Text TxtYourRef, TxtCashPaybag, TxtCodeUser, TxtUserCount;
    public RTLTextMeshPro TxtListPayFaryar, MessageBoxPaybag;
    public GameObject Toman;

    public Text CodeUserMessage;
    public InputField InputEmailMessage;
    public RTLTextMeshPro MessageBoxEmail;
    public TMP_InputField InputTopicMessage, InputTextMessage;

    public RTLTextMeshPro MessageBoxSave;
    public TMP_InputField InputName;
    public InputField InputCardNumber;

    public GameObject MessageFaryar;
    public RTLTextMeshPro TextMessageFaryar;
    public TextMeshProUGUI TextLinkFaryar;
    public String link;

    public GameObject PanelPaybagBook, PanelUnlockBook, PanelPaybagGame, PanelUnlockGame;
    public Button ButtonPaybagBook, ButtonPaybagGame;
    public Text BookfeeLabal, PaybagBookfee, GamefeeLabal, PaybagGamefee;
    public RTLTextMeshPro MessagePaybagBook, MessagePaybagGame;

    public Button shareButton;


    #endregion

    #region Private Variables
    private static String ID;
    private static String UnicID;
    private static String SIMNumber;
    private static String SIMNumberLogin;
    private static String SIMNumberRecovery;
    private static String dataTime;
    private bool isFocus = false;
    private bool isProcessing = false;

    MainMenu menu;
    ZarinpalExample zp;
    #endregion

    #region ObscuredPrefs
    public String PpsCreateCode = "PpsCreateCode";
    public String PpsRefCode = "PpsRefCode";
    public String PpsUserCode = "PpsUserCode";
    public String PpsPassword = "PpsPassword";
    public String PpsCountCode = "PpsCountCode";
    public String PpsCashPaybag = "PpsCashPaybag";
    public String PpsID = "PpsID";
    public String PpsUserName = "PpsUserName";
    public String PpsEmail = "PpsEmail";
    public String PpsCardNumber = "PpsCardNumber";
    public String PpsBookOnline = "PpsBookOnline";
    public String PpsGameOnline = "PpsGameOnline";
    public String PpsBookPaybag = "PpsBookPaybag";
    public String PpsGamePaybag = "PpsGamePaybag";
    public String PpsBookfee = "PpsBookfee";
    public String PpsGamefee = "PpsGamefee";
    public String PpsPayedCash = "PpsPayedCash";
    public String PpsSimNumber = "PpsSimNumber";


    public String PpsBPB = "PpsBPB";
    public String PpsGPB = "PpsGPB";
  
    
    #endregion

    private void Awake()
    {
        menu = gameObject.GetComponentInParent<MainMenu>();
        zp = GameObject.Find("ZarrinPall").gameObject.GetComponent<ZarinpalExample>();
       // ObscuredPrefs.SetInt(PpsCreateCode, 0);
       // ObscuredPrefs.DeleteAll();
    }

    private void Start()
    {
        if (ObscuredPrefs.HasKey(PpsUserCode))
        {
            SendDataTimetoServer();
        }
    }
    #region Connect to Server

    #region Post RefCode to Database
    public void SendRefCodeToServer()
    {
        MessageBoxCheckRef.text = "در حال پردازش";
        StartCoroutine(PostRefCode(InputYourRef.text.ToLower()));
    }

    IEnumerator PostRefCode(String refCode)
    {
        if (InputYourRef.text.Length > 0 && InputYourRef.text.Contains("faryar"))
        {
            WWWForm form = new WWWForm();
            form.AddField("CodeRef", refCode);

            using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PostRefCode.php", form))
            {
                yield return www.SendWebRequest();

                if (www.isNetworkError || www.isHttpError)
                {
                    MessageBoxCheckRef.text = "اتصال برقرار نشد";
                }
                else
                {
                    if (www.downloadHandler.text.Contains("faryar"))
                    {
                        ObscuredPrefs.SetString(PpsRefCode, www.downloadHandler.text);
                        ObscuredPrefs.Save();
                        MessageBoxCheckRef.text = "";
                        menu.CheckPaybagMenu.gameObject.SetActive(false);
                        menu.CreateUserCodeMenu.gameObject.SetActive(true);
                    }
                    else if (www.downloadHandler.text.Contains("NotFind"))
                    {
                        MessageBoxCheckRef.text = "کد معرف وجود ندارد";
                    }
                }
            }
        }
        else if(InputYourRef.text.Length > 0 && !InputYourRef.text.Contains("faryar"))
        {
            MessageBoxCheckRef.text = "کد معرف معتبر وارد کنید";
        }
        else
        {
            MessageBoxCheckRef.text = "کد معرف را وارد کنید";
        }
    }

    #endregion

    #region Create User Code 
    public void SendUnicIDCodeToServer()
    {
        MessageBoxCheckRef.text = "در حال پردازش";
        StartCoroutine(CreateUnicIDforUserCode());
        SetDataCreatePass();
    }

    IEnumerator CreateUnicIDforUserCode()
    {
        SIMNumber = UnicodeDivise();
        UnicID = CreateUnicID();

        WWWForm form = new WWWForm();
        form.AddField("CodeRef", ObscuredPrefs.GetString(PpsRefCode).ToString());
        form.AddField("UnicID", UnicID);
        form.AddField("SimNumber", SIMNumber);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PostUnicIDCode.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageBoxCreate.text = "اتصال برقرار نشد";
            }
            else
            {
                if (www.downloadHandler.text.Contains("faryar") && !www.downloadHandler.text.Contains("zxw"))
                {
                    ObscuredPrefs.SetString(PpsUserCode, www.downloadHandler.text);
                    ObscuredPrefs.Save();
                    menu.CreateUserCodeMenu.gameObject.SetActive(false);
                    menu.Recovery.gameObject.SetActive(true);
                    SetDataRecovery();
                }
                else if (www.downloadHandler.text.Contains("zxw"))
                {
                    menu.CreateUserCodeMenu.gameObject.SetActive(false);
                    menu.CheckPaybagMenu.gameObject.SetActive(true);

                    char[] trimzxw = { 'z', 'x', 'w' };
                    MessageBoxCheckRef.text = "کد معرف شما"+"  "+ www.downloadHandler.text.TrimEnd(trimzxw) + "  "+"می باشد";
                }
                else if (www.downloadHandler.text.Contains("DontCreate"))
                {
                    MessageBoxCreate.text = "کد معرف شماایجاد نشد";
                }
                else if (!www.downloadHandler.text.Contains("DontCreate") && !www.downloadHandler.text.Contains("zxw") && !www.downloadHandler.text.Contains("faryar") )
                {
                    menu.DefinePassword.gameObject.SetActive(true);
                    menu.CreateUserCodeMenu.gameObject.SetActive(false);
                    ID = www.downloadHandler.text;
                    ObscuredPrefs.SetString(PpsID, ID);
                    ObscuredPrefs.SetString(PpsUserCode, (ID + UnicID + "Faryar").ToString());
                    ObscuredPrefs.Save();
                    SetDataCreatePass();
                }
            }
        }
    }
    public static String UnicodeDivise()
    {
        return SystemInfo.deviceUniqueIdentifier;
    }

    private String CreateUnicID()
    {
        return DateTime.Now.ToString("yyMMdd");
    }
    #endregion

    #region Save Password
    public void DefinePassword()
    {
        MessageBoxPass.text = "در حال پردازش";
        StartCoroutine(CreatePasword());
        SetDataPaybag();
    }

    IEnumerator CreatePasword()
    {
        if (InputPassword.text.Length >= 6 && InputEmailwithPass.text.Contains("@") && InputEmailwithPass.text.Contains("."))
        {
            WWWForm form = new WWWForm();
            form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
            form.AddField("Password", InputPassword.text);
            form.AddField("Email", InputEmailwithPass.text);

            using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/DefinePassword.php", form))
            {
                yield return www.SendWebRequest();

                if (www.isNetworkError || www.isHttpError)
                {
                    MessageBoxPass.text = "اتصال برقرار نشد";
                }
                else
                {
                    if (!www.downloadHandler.text.Contains("DontOk"))
                    {
                        ObscuredPrefs.SetInt(PpsCreateCode, 1);
                        ObscuredPrefs.SetString(PpsPassword, InputPassword.text);
                        ObscuredPrefs.SetString(PpsEmail, InputEmailwithPass.text);
                        ObscuredPrefs.Save();
                        menu.Login.gameObject.SetActive(false);
                        menu.StoryMenuHolder.gameObject.SetActive(false);
                        menu.DefinePassword.gameObject.SetActive(false);
                        menu.PayBagStoryMenu.gameObject.SetActive(true);
                        SetDataPaybag();
                    }
                    else if (www.downloadHandler.text.Contains("DontOk"))
                    {
                        MessageBoxPass.text = "رمز عبور شما ذخیره نشد";
                    }

                }
            }
        }
        else if (InputPassword.text.Length == 0 && InputEmailwithPass.text.Length > 0)
        {
            MessageBoxPass.text = "رمز عبور خود را وارد کنید";
        }
        else if (InputPassword.text.Length < 6 && InputEmailwithPass.text.Length > 0)
        {
            MessageBoxPass.text = "رمز عبور حداقل 6 رقم باشد";
        }
        else if (InputPassword.text.Length >= 6 && InputEmailwithPass.text.Length == 0)
        {
            MessageBoxPass.text = "ایمیل خود را وارد کنید";
        }
        else if (InputPassword.text.Length < 6 && !InputEmailwithPass.text.Contains("@") || !InputEmailwithPass.text.Contains("."))
        {
            MessageBoxPass.text = "ایمیل و رمز عبور معتبر وارد کنید";
        }
        else if (InputPassword.text.Length > 6 && !InputEmailwithPass.text.Contains("@") || !InputEmailwithPass.text.Contains("."))
        {
            MessageBoxPass.text = "ایمیل معتبر وارد کنید";
        }
        else if (InputPassword.text.Length == 0 && InputEmailwithPass.text.Length == 0)
        {
            MessageBoxPass.text = "فرم را پر کنید";
        }
        else
        {
            MessageBoxPass.text = "فرم را صحیح پر کنید";
        }
    }
    #endregion

    #region Login User
    public void LoginUser()
    {
        MessageBoxLogin.text = "در حال پردازش";
        StartCoroutine(Login());
        SetDataPaybag();
    }

    IEnumerator Login()
    {
        SIMNumberLogin = UnicodeDivise();

        if (InputPasswordLogin.text.Length >= 6 && InputCodeUserLogin.text.ToLower().Contains("faryar"))
        {
            WWWForm form = new WWWForm();
            form.AddField("CodeUser", InputCodeUserLogin.text);
            form.AddField("Password", InputPasswordLogin.text);

            using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/Login.php", form))
            {
                yield return www.SendWebRequest();

                if (www.isNetworkError || www.isHttpError)
                {
                    MessageBoxLogin.text = "اتصال برقرار نشد";
                }
                else
                {
                    if (SIMNumberLogin == www.downloadHandler.text)
                    {
                        ObscuredPrefs.SetInt(PpsCreateCode, 1);
                        ObscuredPrefs.SetString(PpsPassword, InputPasswordLogin.text);
                        ObscuredPrefs.SetString(PpsUserCode, InputCodeUserLogin.text);
                        ObscuredPrefs.Save();
                        menu.Login.gameObject.SetActive(false);
                        menu.PayBagStoryMenu.gameObject.SetActive(true);
                        SetDataPaybag();
                    }
                    else if (SIMNumberLogin != www.downloadHandler.text)
                    {
                        MessageBoxLogin.text = "اطلاعات وارد شده صحیح نیست";
                    }
                    else
                    {
                        MessageBoxLogin.text = "حساب شما معتبر نیست";
                    }
                }
            }
        }
        else if (InputPasswordLogin.text.Length == 0 && InputCodeUserLogin.text.Length == 0)
        {
            MessageBoxLogin.text = "کد معرف و رمز عبور را وارد کنید ";
        }
        else if (InputPasswordLogin.text.Length >= 6 && InputCodeUserLogin.text.Length == 0)
        {
            MessageBoxLogin.text = "کد معرف خود را وارد کنید";
        }
        else if (InputPasswordLogin.text.Length == 0 && InputCodeUserLogin.text.Length != 0)
        {
            MessageBoxLogin.text = "رمز عبور خود را وارد کنید";
        }
        else if (InputPasswordLogin.text.Length < 6 && InputCodeUserLogin.text.Length != 0)
        {
            MessageBoxLogin.text = "رمز عبور حداقل 6 رقم باشد";
        }

        else if (InputPasswordLogin.text.Length >= 6 && !InputCodeUserLogin.text.ToLower().Contains("faryar"))
        {
            MessageBoxLogin.text = "کد معرف معتبر وارد کنید";
        }
        else
        {
            MessageBoxLogin.text = "فرم را صحیح پر کنید";
        }

    }

    #endregion

    #region Recovery Password
    public void Recovery()
    {
        MessageBoxRecovery.text = "در حال پردازش";
        StartCoroutine(RecoveryPassword());
        SetDataCreatePass();
    }

    IEnumerator RecoveryPassword()
    {
        SIMNumberRecovery = UnicodeDivise();

        if (InputEmailRecovery.text.Contains("@") && InputEmailRecovery.text.Contains(".") && InputCodeUserRecovery.text.ToLower().Contains("faryar"))
        {
            WWWForm form = new WWWForm();
            form.AddField("CodeUser", InputCodeUserRecovery.text);
            form.AddField("Email", InputEmailRecovery.text);

            using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/Recovery.php", form))
            {
                yield return www.SendWebRequest();

                if (www.isNetworkError || www.isHttpError)
                {
                    MessageBoxRecovery.text = "اتصال برقرار نشد";
                }
                else
                {
                    if (SIMNumberRecovery == www.downloadHandler.text)
                    {
                        ObscuredPrefs.SetString(PpsEmail, InputEmailRecovery.text);
                        ObscuredPrefs.SetString(PpsUserCode, InputCodeUserRecovery.text);
                        ObscuredPrefs.Save();
                        menu.Recovery.gameObject.SetActive(false);
                        menu.DefinePassword.gameObject.SetActive(true);
                        SetDataCreatePass();
                    }
                    else if (SIMNumberRecovery != www.downloadHandler.text)
                    {
                        MessageBoxRecovery.text = "اطلاعات وارد شده صحیح نیست";
                    }
                    else
                    {
                        MessageBoxRecovery.text = "حساب شما معتبر نیست";
                    }

                }
            }
        }
        else if (InputEmailRecovery.text.Length == 0 && InputCodeUserRecovery.text.Length == 0)
        {
            MessageBoxRecovery.text = "کد معرف و ایمیل خود را وارد کنید";
        }
        else if (InputEmailRecovery.text.Length == 0 && InputCodeUserRecovery.text.ToLower().Contains("faryar"))
        {
            MessageBoxRecovery.text = "ایمیل خود را وارد کنید";
        }
        else if (!InputEmailRecovery.text.Contains("@") || !InputEmailRecovery.text.Contains(".") && InputCodeUserRecovery.text.ToLower().Contains("faryar"))
        {
            MessageBoxRecovery.text = "ایمیل معتبر وارد کنید";
        }
        else if (!InputEmailRecovery.text.Contains("@") || !InputEmailRecovery.text.Contains(".") && !InputCodeUserRecovery.text.ToLower().Contains("faryar"))
        {
            MessageBoxRecovery.text = "کد معرف و ایمیل معتبر وارد کنید";
        }
        else if (InputEmailRecovery.text.Contains("@") && InputEmailRecovery.text.Contains(".") && InputCodeUserLogin.text.Length == 0)
        {
            MessageBoxRecovery.text = "کد معرف خود را وارد کنید";
        }
        else if (InputEmailRecovery.text.Contains("@") && InputEmailRecovery.text.Contains(".") && !InputCodeUserRecovery.text.ToLower().Contains("faryar"))
        {
            MessageBoxRecovery.text = "کد معرف معتبر وارد کنید";
        }
        else
        {
            MessageBoxRecovery.text = "فرم را صحیح پر کنید";
        }
    }

    #endregion

    #region Save Data and Send to server 
    public void SaveandSendDataToServer()
    {
        MessageBoxSave.text = "در حال پردازش";
        if (!String.IsNullOrEmpty(InputName.text) && InputCardNumber.text.Length == 16)
        {
            StartCoroutine(SaveandSendData(InputName.text, InputCardNumber.text));
        }
        else
        {
            if (!String.IsNullOrEmpty(InputName.text) && InputCardNumber.text.Length != 16)
            {
                MessageBoxSave.text = "شماره کارت را درست وارد کنید";
            }
            else if (String.IsNullOrEmpty(InputName.text) && InputCardNumber.text.Length != 0)
            {
                MessageBoxSave.text = "نام خود را وارد کنید";
            }
            else if (!String.IsNullOrEmpty(InputName.text) && InputCardNumber.text.Length == 0)
            {
                MessageBoxSave.text = "شماره کارت خود را وارد کنید";
            }
            else
            {
                MessageBoxSave.text = "فرم را پر کنید";
            }
        }
    }

    IEnumerator SaveandSendData(String userName, String cardNumber)
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode));
        form.AddField("UserName", userName);
        form.AddField("CardNumber", cardNumber);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PostDataUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageBoxSave.text = "اتصال برقرار نشد";
            }
            else
            {
                if (www.downloadHandler.text.Contains("Saved"))
                {
                    MessageBoxSave.text = "اطلاعات شما ذخیره شد";
                    ObscuredPrefs.SetString(PpsUserName, userName.ToString());
                    ObscuredPrefs.SetString(PpsCardNumber, cardNumber.ToString());
                    ObscuredPrefs.Save();
                    menu.SaveDataPanelHolder.gameObject.SetActive(false);
                }
                else if (www.downloadHandler.text.Contains("DontSave"))
                {
                    MessageBoxSave.text = "اطلاعات شما ذخیره نشد";
                }

            }
        }
    }

    #endregion

    #region Send Message to server 
    public void SendMessagetoServer()
    {
        MessageBoxEmail.text = "در حال پردازش";
        if (!String.IsNullOrEmpty(InputTopicMessage.text) && !String.IsNullOrEmpty(InputTextMessage.text) && InputEmailMessage.text.Contains("@") && InputEmailMessage.text.Contains("."))
        {
            StartCoroutine(SendMessage(InputEmailMessage.text, InputTopicMessage.text, InputTextMessage.text));
            SetDataEmail();
        }
        else
        {
            if (String.IsNullOrEmpty(InputTopicMessage.text) && InputTextMessage.text.Length != 0 && InputEmailMessage.text.Length != 0)
            {
                MessageBoxEmail.text = "موضوع را وارد کنید";
            }
            else if (String.IsNullOrEmpty(InputTextMessage.text) && InputTopicMessage.text.Length != 0 && InputEmailMessage.text.Length != 0)
            {
                MessageBoxEmail.text = "متن را وارد کنید";
            }
            else if (InputEmailMessage.text.Length == 0 && !String.IsNullOrEmpty(InputTopicMessage.text) && !String.IsNullOrEmpty(InputTextMessage.text))
            {
                MessageBoxEmail.text = "ایمیل خود را وارد کنید";
            }
            else
            {
                MessageBoxEmail.text = "فرم را صحیح پر کنید";
            }
        }
    }

    IEnumerator SendMessage(String email, String hedEmail, String textEmail)
    {
        WWWForm form = new WWWForm();
        form.AddField("ID", ObscuredPrefs.GetString(PpsID));
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode));
        form.AddField("Email", email);
        form.AddField("HedEmail", hedEmail);
        form.AddField("TextEmail", textEmail);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PostMessage.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageBoxEmail.text = "اتصال برقرار نشد";
            }
            else
            {
                if (www.downloadHandler.text.Contains("Send"))
                {
                    ObscuredPrefs.SetString(PpsEmail, email.ToString());
                    MessageBoxEmail.text = "پیام شما ارسال شد";
                    menu.SendEmailPanelHolder.gameObject.SetActive(false);
                }
                else if (www.downloadHandler.text.Contains("DontSend"))
                {
                    MessageBoxEmail.text = "پیام شما ارسال نشد";
                }

            }
        }
    }

    #endregion

    #region Recive List Pay from server 
    public void RecieveListPayFromServer()
    {
        StartCoroutine(TextofList());
    }

    IEnumerator TextofList()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/TextofList.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageBoxPaybag.text = "اتصال برقرار نشد";
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    TxtListPayFaryar.text = www.downloadHandler.text;
                }
                else
                {
                    TxtListPayFaryar.text = "پرداختی انجام نشده است" + "\n\n" + "کیف پول شما به حد نصاب نرسیده است";
                }
            }
        }
    }

    #endregion

    #region Send Message from server 
    public void SendMessageFaryarFromServer()
    {
        StartCoroutine(MessageFaryarIE());
    }

    IEnumerator MessageFaryarIE()
    {
        MessageFaryar.gameObject.SetActive(true);
        TextMessageFaryar.text = "در حال پردازش";

        if (ObscuredPrefs.HasKey(PpsUserCode))
        {
            WWWForm form = new WWWForm();
            form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

            using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/MessageFaryar.php", form))
            {
                yield return www.SendWebRequest();

                if (www.isNetworkError || www.isHttpError)
                {
                    TextMessageFaryar.text = "برای اطلاع از خبرهای فریار" + "\n" + " به اتصال اینترنت نیاز دارید";
                }
                else
                {
                    if (!www.downloadHandler.text.Contains("NotOk"))
                    {
                        MessageFaryar.gameObject.SetActive(true);
                        link = www.downloadHandler.text;
                        if (link.Length > 0)
                        {
                            TextMessageFaryar.text = "در گروه آموزشی فریار خبرایی هست..." + "\n\n" + "لینک زیر رو لمس کن";
                            TextLinkFaryar.text = "<link=MessageFaryar>" + link + "</link>";
                        }
                        else
                        {
                            TextMessageFaryar.text = "منتظر خبرهای خوب از گروه آموزشی فریار باشید";
                        }
                    }
                    else
                    {
                        TextMessageFaryar.text = "منتظر خبرهای خوب از گروه آموزشی فریار باشید";
                    }
                }
            }
        }
        else
        {
            TextMessageFaryar.text = "برای خبرنامه نیاز به ایجاد کد معرف دارید" + "\n" + "از قسمت 42 داستان فارسی به کیف پول مراجعه کنید";
        }
    }

    #endregion

    #region Get RefCode and Email
    public void GetRefCodeEmail()
    {
        StartCoroutine(RefCodeEmail());
    }
    IEnumerator RefCodeEmail()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetRefCode.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetString(PpsRefCode, www.downloadHandler.text);
                }
            }
        }
        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetEmail.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetString(PpsEmail, www.downloadHandler.text);
                }
            }
        }
    }
    #endregion

    #region Update
    public void UpdatePaybag()
    {
        MessageBoxPaybag.text = "در حال پردازش";
        StartCoroutine(Count());
        SetCashPaybag();
        RecieveListPayFromServer();
        SetDataPaybag();
        SetDataEmail();
        SetDataSave();
        StartCoroutine(PpsBookGame());
        SendDataTimetoServer();
    }

    public IEnumerator Count()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/Count.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageFaryar.gameObject.SetActive(true);
                TextMessageFaryar.text = "اتصال برقرار نشد";
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    MessageBoxPaybag.text = "بروزرسانی انجام شد";
                    TxtUserCount.text = www.downloadHandler.text;
                    ObscuredPrefs.SetString(PpsCountCode, TxtUserCount.text);
                    ObscuredPrefs.Save();
                }
                else if (www.downloadHandler.text.Contains("NotOk"))
                {
                    MessageBoxPaybag.text = "کسی را معرفی نکرده اید";
                    TxtUserCount.text = "0";
                }

            }
        }
    }

    public IEnumerator Cash()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

        using (UnityWebRequest www1 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/CashOnlineBook.php", form))
        {
            yield return www1.SendWebRequest();

            if (www1.isNetworkError || www1.isHttpError)
            {

            }
            else
            {
                if (!www1.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsBookOnline, IntParseFast(www1.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
                else
                {
                    ObscuredPrefs.SetInt(PpsBookOnline, 0);
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www2 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/CashPaybagBook.php", form))
        {
            yield return www2.SendWebRequest();

            if (www2.isNetworkError || www2.isHttpError)
            { }
            else
            {
                if (!www2.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsBookPaybag, IntParseFast(www2.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
                else
                {
                    ObscuredPrefs.SetInt(PpsBookPaybag, 0);
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www3 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/CashOnlineGame.php", form))
        {
            yield return www3.SendWebRequest();

            if (www3.isNetworkError || www3.isHttpError)
            { }
            else
            {
                if (!www3.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsGameOnline, IntParseFast(www3.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
                else
                {
                    ObscuredPrefs.SetInt(PpsGameOnline, 0);
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www4 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/CashPaybagGame.php", form))
        {
            yield return www4.SendWebRequest();

            if (www4.isNetworkError || www4.isHttpError)
            { }
            else
            {
                if (!www4.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsGamePaybag, IntParseFast(www4.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
                else
                {
                    ObscuredPrefs.SetInt(PpsGamePaybag, 0);
                    ObscuredPrefs.Save();
                }
            }
        }

    }

    public IEnumerator PpsBookGame()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

        using (UnityWebRequest www1 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PpsBOL.php", form))
        {
            yield return www1.SendWebRequest();

            if (www1.isNetworkError || www1.isHttpError)
            {
            }
            else
            {
                if (!www1.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(zp.PpsBOL, IntParseFast(www1.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www2 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PpsBPB.php", form))
        {
            yield return www2.SendWebRequest();

            if (www2.isNetworkError || www2.isHttpError)
            { }
            else
            {
                if (!www2.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsBPB, IntParseFast(www2.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www3 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PpsGOL.php", form))
        {
            yield return www3.SendWebRequest();

            if (www3.isNetworkError || www3.isHttpError)
            { }
            else
            {
                if (!www3.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(zp.PpsGOL, IntParseFast(www3.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www4 = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/PpsGPB.php", form))
        {
            yield return www4.SendWebRequest();

            if (www4.isNetworkError || www4.isHttpError)
            { }
            else
            {
                if (!www4.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsGPB, IntParseFast(www4.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
    }

    public IEnumerator SendCashPaybagToServer()
    {
        SetCashPaybag();
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashPaybagUser", ObscuredPrefs.GetInt(PpsCashPaybag).ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/SendCashPaybag.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
        }
    }
    #endregion

    #region Recive Bookfee and Gamefee and PayedCash from Server
    public void RecieveBookfeeandGamefeeandPayedCashFromServer()
    {
        StartCoroutine(BookfeeGamefee());
    }

    public IEnumerator BookfeeGamefee()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetBookfee.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsBookfee, IntParseFast(www.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetGamefee.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsGamefee, IntParseFast(www.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetPayedCash.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsPayedCash, IntParseFast(www.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
    }

    #endregion

    #region Lock Book

    public void OpenLockBookwithPaybagBook()
    {
        if (ObscuredPrefs.GetString(PpsUserCode).ToLower().Contains("faryar"))
        {
            SetCashPaybag();
            PanelUnlockBook.gameObject.SetActive(false);
            PanelPaybagBook.gameObject.SetActive(true);
            BookfeeLabal.text = ObscuredPrefs.GetInt(PpsBookfee).ToString();
            PaybagBookfee.text = ObscuredPrefs.GetInt(PpsCashPaybag).ToString();
            if (ObscuredPrefs.GetInt(PpsCashPaybag) >= ObscuredPrefs.GetInt(PpsBookfee))
            {
                if (ObscuredPrefs.GetInt(zp.PpsBOL) == 0 && ObscuredPrefs.GetInt(PpsBPB) == 0)
                {
                    ButtonPaybagBook.interactable = true;
                    MessagePaybagBook.text = "با لمس پرداخت فعال سازی کتاب انجام می شود";
                }
            }
            else
            {
                ButtonPaybagBook.interactable = false;
                MessagePaybagBook.text = "موجودی کیف پول شما کافی نیست";
            }
        }
        else
        {
            MessageFaryar.gameObject.SetActive(true);
            TextMessageFaryar.text = "کد معرف خود را ایجاد نکرده اید";
        }
    }

    public void PayButtonBook()
    {
        StartCoroutine(CheckandSetPayBookfee());
        PanelPaybagBook.gameObject.SetActive(false);
        menu.StoryMenuHolder.gameObject.SetActive(false);
        menu.PayBagStoryMenu.gameObject.SetActive(true);
        MessageBoxPaybag.text = "بروزرسانی کنید";
    }

    public IEnumerator CheckandSetPayBookfee()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashPaybagBook", 1);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetPaybagBookfee.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageFaryar.gameObject.SetActive(true);
                TextMessageFaryar.text = "اتصال برقرار نشد";
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    if (IntParseFast(www.downloadHandler.text) == 1)
                    {
                        ObscuredPrefs.SetInt(zp.PpsBOL, 0);
                        ObscuredPrefs.SetInt(PpsBPB, 1);
                        ObscuredPrefs.Save();
                    }
                    else if (IntParseFast(www.downloadHandler.text) == 2)
                    {
                        StartCoroutine(UpdatePpsBookPaybag());
                    }
                }
            }
        }
    }

    public IEnumerator UpdatePpsBookPaybag()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashPaybagBook", 0);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/UpdateCashPaybagBook.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageFaryar.gameObject.SetActive(true);
                TextMessageFaryar.text = "اتصال برقرار نشد";
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(zp.PpsBOL, IntParseFast(www.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
    }
    #endregion

    #region Lock Game
    public void OpenLockGamewithPaybagGame()
    {
        if (ObscuredPrefs.GetString(PpsUserCode).ToLower().Contains("faryar"))
        {
            SetCashPaybag();
            PanelUnlockGame.gameObject.SetActive(false);
            PanelPaybagGame.gameObject.SetActive(true);
            GamefeeLabal.text = ObscuredPrefs.GetInt(PpsGamefee).ToString();
            PaybagGamefee.text = ObscuredPrefs.GetInt(PpsCashPaybag).ToString();
            if (ObscuredPrefs.GetInt(PpsCashPaybag) >= ObscuredPrefs.GetInt(PpsGamefee))
            {
                if (ObscuredPrefs.GetInt(PpsGameOnline) == 0 && ObscuredPrefs.GetInt(PpsGamePaybag) == 0)
                {
                    ButtonPaybagGame.interactable = true;
                    MessagePaybagGame.text = "با لمس پرداخت فعال سازی بازی انجام می شود";
                }
            }
            else
            {
                ButtonPaybagGame.interactable = false;
                MessagePaybagGame.text = "موجودی کیف پول شما کافی نیست";
            }
        }

        else
        {
            MessageFaryar.gameObject.SetActive(true);
            TextMessageFaryar.text = "کد معرف خود را ایجاد نکرده اید";
        }
    }

    public void PayButtonGame()
    {
        StartCoroutine(CheckandSetPayGamefee());
        PanelPaybagGame.gameObject.SetActive(false);
        menu.GameSwitchHolder.gameObject.SetActive(false);
        menu.PayBagStoryMenu.gameObject.SetActive(true);
        MessageBoxPaybag.text = "بروزرسانی کنید";
    }

    public IEnumerator CheckandSetPayGamefee()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashPaybagGame", 1);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/GetPaybagGamefee.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageFaryar.gameObject.SetActive(true);
                TextMessageFaryar.text = "اتصال برقرار نشد";
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    if (IntParseFast(www.downloadHandler.text) == 1)
                    {
                        ObscuredPrefs.SetInt(zp.PpsGOL, 0);
                        ObscuredPrefs.SetInt(PpsGPB, 1);
                        ObscuredPrefs.Save();
                    }
                    else if (IntParseFast(www.downloadHandler.text) == 2)
                    {
                        StartCoroutine(UpdatePpsGamePaybag());
                    }
                }
            }
        }
    }

    public IEnumerator UpdatePpsGamePaybag()
    {
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashPaybagGame", 0);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/UpdateCashPaybagGame.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                MessageFaryar.gameObject.SetActive(true);
                TextMessageFaryar.text = "اتصال برقرار نشد";
            }
            else
            {
                if (!www.downloadHandler.text.Contains("NotOk"))
                {
                    ObscuredPrefs.SetInt(PpsGPB, IntParseFast(www.downloadHandler.text));
                    ObscuredPrefs.Save();
                }
            }
        }
    }

    #endregion

    #region Send Pps Book Online and Game Online to Server
    public void SendPpsBOLtoServer()
    {
        StartCoroutine(SendPpsBookOnlineToServer());
    }

    public IEnumerator SendPpsBookOnlineToServer()
    {
        SetCashPaybag();
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashOnlineBook", ObscuredPrefs.GetInt(zp.PpsBOL).ToString());
        form.AddField("CashOnlineBookToken", ObscuredPrefs.GetString(zp.PpsBOLToken).ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/UpdatePpsBookOnline.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                CheckOpenBook();
            }
        }
    }
    public void SendPpsGOLtoServer()
    {
        StartCoroutine(SendPpsGameOnlineToServer());
    }

    public IEnumerator SendPpsGameOnlineToServer()
    {
        SetCashPaybag();
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("CashOnlineGame", ObscuredPrefs.GetInt(zp.PpsGOL).ToString());
        form.AddField("CashOnlineGameToken", ObscuredPrefs.GetString(zp.PpsGOLToken).ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/UpdatePpsGameOnline.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            }
            else
            {
                CheckOpenGame();
            }
        }
    }
    #endregion

    #region Send data time to server
    public void SendDataTimetoServer()
    {
        StartCoroutine(SenddatatimeToServer());
    }

    public IEnumerator SenddatatimeToServer()
    {
        dataTime = DataTimeNow();
        WWWForm form = new WWWForm();
        form.AddField("CodeUser", ObscuredPrefs.GetString(PpsUserCode).ToLower());
        form.AddField("DataTime", dataTime);

        using (UnityWebRequest www = UnityWebRequest.Post("http://faryarteam.ir/Unity/Coding504/DataTime.php", form))
        {
            yield return www.SendWebRequest();
        }
    }

    private String DataTimeNow()
    {
        return DateTime.Now.ToString("yyyyMMddHHmmss");
    }
    #endregion

    #endregion

    #region Not Need to Connect Server

    #region Set Data Paybag
    public void SetDataPaybag()
    {
        TxtCodeUser.text = ObscuredPrefs.GetString(PpsUserCode);
        TxtUserCount.text = ObscuredPrefs.GetString(PpsCountCode);
        TxtCashPaybag.text = ObscuredPrefs.GetInt(PpsCashPaybag).ToString();
        TextPassword.text = ObscuredPrefs.GetString(PpsPassword);

        if (ObscuredPrefs.HasKey(PpsRefCode))
        {
            TxtYourRef.text = ObscuredPrefs.GetString(PpsRefCode);
        }
        else
        {
            GetRefCodeEmail();
        }
    }
    #endregion

    #region Set Data Email of Paybag
    public void SetDataEmail()
    {
        CodeUserMessage.text = ObscuredPrefs.GetString(PpsUserCode);

        if (ObscuredPrefs.HasKey(PpsEmail))
        {
            if (ObscuredPrefs.GetString(PpsEmail).Contains("@"))
            {
                InputEmailMessage.text = ObscuredPrefs.GetString(PpsEmail);
            }
        }
        else
        {
            GetRefCodeEmail();
            InputEmailMessage.text = ObscuredPrefs.GetString(PpsEmail);
        }
    }
    #endregion

    #region Set Data Create Password Panel
    public void SetDataCreatePass()
    {
        CodeUserPass.text = ObscuredPrefs.GetString(PpsUserCode);

        if (ObscuredPrefs.HasKey(PpsEmail))
        {
            if (ObscuredPrefs.GetString(PpsEmail).Contains("@"))
            {
                InputEmailwithPass.text = ObscuredPrefs.GetString(PpsEmail);
            }
        }
        else
        {
            GetRefCodeEmail();
            InputEmailwithPass.text = ObscuredPrefs.GetString(PpsEmail);
        }
    }
    #endregion

    #region Set Data Save of Paybag
    public void SetDataSave()
    {
        if (ObscuredPrefs.HasKey(PpsUserName))
        {
            InputName.text = ObscuredPrefs.GetString(PpsUserName);
        }
        if (ObscuredPrefs.HasKey(PpsCardNumber))
        {
            InputCardNumber.text = ObscuredPrefs.GetString(PpsCardNumber);
        }
    }
    #endregion

    #region Set Data Recovery
    public void SetDataRecovery()
    {
        InputCodeUserRecovery.text = ObscuredPrefs.GetString(PpsUserCode);
        InputEmailRecovery.text = ObscuredPrefs.GetString(PpsEmail);
    }
    #endregion

    #region Set Pps Cash Paybag
    public void SetCashPaybag()
    {
        StartCoroutine(Cash());
        RecieveBookfeeandGamefeeandPayedCashFromServer();
    
        ObscuredPrefs.SetInt(PpsCashPaybag, (ObscuredPrefs.GetInt(PpsBookOnline) + ObscuredPrefs.GetInt(PpsBookPaybag) + ObscuredPrefs.GetInt(PpsGameOnline) + ObscuredPrefs.GetInt(PpsGamePaybag) - ObscuredPrefs.GetInt(PpsPayedCash)));
       
        if(ObscuredPrefs.GetInt(PpsBPB) > 0)
        {
            ObscuredPrefs.SetInt(PpsCashPaybag, (ObscuredPrefs.GetInt(PpsCashPaybag) - ObscuredPrefs.GetInt(PpsBookfee)));
        }
        if (ObscuredPrefs.GetInt(PpsGPB) > 0)
        {
            ObscuredPrefs.SetInt(PpsCashPaybag, (ObscuredPrefs.GetInt(PpsCashPaybag) - ObscuredPrefs.GetInt(PpsGamefee)));
        }
        if (ObscuredPrefs.GetInt(PpsCashPaybag) > 0)
        {
            Toman.gameObject.SetActive(true);
        }
        else
        {
            TxtCashPaybag.text = "0";
            Toman.gameObject.SetActive(false);
        }
        TxtCashPaybag.text = (ObscuredPrefs.GetInt(PpsCashPaybag)).ToString();
    }
    #endregion

    #region Check Open Book and Game
    public void CheckOpenBook() 
    {
        if (ObscuredPrefs.GetInt(zp.PpsBOL) > 0 || ObscuredPrefs.GetInt(PpsBPB) > 0)
        {
            menu.ButtonPayBook.gameObject.SetActive(true);
            menu.ButtonPayBookBazzar.gameObject.SetActive(false);
        }
        else if (ObscuredPrefs.GetInt(zp.PpsBOL) == 0 && ObscuredPrefs.GetInt(PpsBPB) == 0)
        {
            menu.ButtonPayBook.gameObject.SetActive(false);
            menu.ButtonPayBookBazzar.gameObject.SetActive(true);
        }
    }
    public void CheckOpenGame()
    {
        if (ObscuredPrefs.GetInt(zp.PpsGOL) > 0 || ObscuredPrefs.GetInt(PpsGPB) > 0)
        {
            menu.ButtonPayGame.gameObject.SetActive(true);
            menu.ButtonPayGameBazzar.gameObject.SetActive(false);
        }
        else if (ObscuredPrefs.GetInt(zp.PpsGOL) == 0 && ObscuredPrefs.GetInt(PpsGPB) == 0)
        {
            menu.ButtonPayGame.gameObject.SetActive(false);
            menu.ButtonPayGameBazzar.gameObject.SetActive(true);
        }
    }
    #endregion

    #region Check Open Button Pay Book and Game
    public void CheckButtonPayBook()
    {
        if (ObscuredPrefs.GetInt(zp.PpsBOL) > 0 || ObscuredPrefs.GetInt(PpsBPB) > 0)
        {
            menu.ButtonPayBagBook.interactable = false;
            menu.ButtonOnlineBook.interactable = false;
        }
        else if (ObscuredPrefs.GetInt(zp.PpsBOL) == 0 && ObscuredPrefs.GetInt(PpsBPB) == 0)
        {
            menu.ButtonPayBagBook.interactable = true;
            menu.ButtonOnlineBook.interactable = true;
        }
    }
    public void CheckButtonPayGame()
    {
        if (ObscuredPrefs.GetInt(zp.PpsGOL) > 0 || ObscuredPrefs.GetInt(PpsGPB) > 0)
        {
            menu.ButtonPayBagGame.interactable = false;
            menu.ButtonOnlineGame.interactable = false;
        }
        else if (ObscuredPrefs.GetInt(zp.PpsGOL) == 0 && ObscuredPrefs.GetInt(PpsGPB) == 0)
        {
            menu.ButtonPayBagGame.interactable = true;
            menu.ButtonOnlineGame.interactable = true;
        }
    }
    #endregion


    #region Share Buttom


    void OnApplicationFocus(bool focus)
    {
        isFocus = focus;
    }

    public void ShareText()
    {
        menu.PlayClick();
        if (ObscuredPrefs.GetString(PpsUserCode).ToLower().Contains("faryar"))
        {

            if (!isProcessing)
            {
            StartCoroutine(ShareTextInAnroid());
            }

        }
        else
        {
            MessageFaryar.gameObject.SetActive(true);
            TextMessageFaryar.text = "کد معرف خود را ایجاد نکرده اید";
        }
    }

    public IEnumerator ShareTextInAnroid()
    {

        var shareSubject = "اشتراک گذاری نرم افزار آموزشی کدینگ 504";
        var shareMessage = "سلام دوست عزیز"+"\n"+"نرم افزار آموزش زبان انگلیسی کدینگ 504 گروه آموزشی فریار منتشر شد"
                            +"\n\n"
                            +"http://cafebazaar.ir/app/ir.FaryarTeam.Coding504"
                            + "\n\n"+"کیف پول خودت رو با کد معرف زیر فعال کن:" +
                           "\n" + ObscuredPrefs.GetString(PpsUserCode).ToLower() + "\n\n"
                           +"داستان فارسی بخون، جورچین بازی کن و زبان انگلیسی یاد بگیر";

        isProcessing = true;

        if (!Application.isEditor)
        {
            //Create intent for action send
            AndroidJavaClass intentClass =
                new AndroidJavaClass("android.content.Intent");
            AndroidJavaObject intentObject =
                new AndroidJavaObject("android.content.Intent");
            intentObject.Call<AndroidJavaObject>
                ("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

            //put text and subject extra
            intentObject.Call<AndroidJavaObject>("setType", "text/plain");
            intentObject.Call<AndroidJavaObject>
                ("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), shareSubject);
            intentObject.Call<AndroidJavaObject>
                ("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareMessage);

            //call createChooser method of activity class
            AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity =
                unity.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject chooser =
                intentClass.CallStatic<AndroidJavaObject>
                ("createChooser", intentObject, shareSubject);
            currentActivity.Call("startActivity", chooser);
        }

        yield return new WaitUntil(() => isFocus);
        isProcessing = false;
    }

    #endregion


    public static int IntParseFast(String value)
    {
        int result = 0;
        for (int i = 0; i < value.Length; i++)
        {
            char letter = value[i];
            result = 10 * result + (letter - 48);
        }
        return result;
    }

    private void OnApplicationQuit()
        {
            ObscuredPrefs.Save();
        }

    #endregion
}

