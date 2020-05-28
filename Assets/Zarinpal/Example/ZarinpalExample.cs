using System;
using UnityEngine;
using UnityEngine.UI;
using RTLTMPro;
using CodeStage.AntiCheat.Storage;


public class ZarinpalExample : MonoBehaviour
{
    public GameObject Succesfullpanel;
    public GameObject Failedpanel;
    public GameObject Loadingpanel;
    public GameObject Faryar;
    public RTLTextMeshPro m_text;
    private String m_amount;
    private String m_desc;
    public RTLTextMeshPro productName;
    public RTLTextMeshPro Token;
    FaryarDataBase db;

    public String PpsBOL = "PpsBOL";
    public String PpsGOL = "PpsGOL";
    public String PpsBOLToken = "PpsBOLToken";
    public String PpsGOLToken = "PpsGOLToken";

    private void Awake()
    {
      //  menu = gameObject.GetComponentInParent<MainMenu>();
        db = GameObject.Find("DatabaseControler").gameObject.GetComponent<FaryarDataBase>();
    }

    void Start()
    {
        Zarinpal.StoreInitialized += Zarinpal_StoreInitialized;
        Zarinpal.StoreInitializeFailed += Zarinpal_StoreInitializeFailed;
        Zarinpal.PurchaseStarted += Zarinpal_PurchaseStarted;
        Zarinpal.PurchaseFailedToStart += Zarinpal_PurchaseFailedToStart;
        Zarinpal.PurchaseSucceed += Zarinpal_PurchaseSucceed;
        Zarinpal.PurchaseFailed += Zarinpal_PurchaseFailed;
        Zarinpal.PurchaseCanceled += Zarinpal_PurchaseCanceled;
        Zarinpal.PaymentVerificationStarted += Zarinpal_PaymentVerificationStarted;
        Zarinpal.PaymentVerificationSucceed += Zarinpal_PaymentVerificationSucceed;
        Zarinpal.PaymentVerificationFailed += Zarinpal_PaymentVerificationFailed;
    }

    void OnDestroy()
    {
        Zarinpal.StoreInitialized -= Zarinpal_StoreInitialized;
        Zarinpal.StoreInitializeFailed -= Zarinpal_StoreInitializeFailed;
        Zarinpal.PurchaseStarted -= Zarinpal_PurchaseStarted;
        Zarinpal.PurchaseFailedToStart -= Zarinpal_PurchaseFailedToStart;
        Zarinpal.PurchaseSucceed -= Zarinpal_PurchaseSucceed;
        Zarinpal.PurchaseFailed -= Zarinpal_PurchaseFailed;
        Zarinpal.PurchaseCanceled -= Zarinpal_PurchaseCanceled;
        Zarinpal.PaymentVerificationStarted -= Zarinpal_PaymentVerificationStarted;
        Zarinpal.PaymentVerificationSucceed -= Zarinpal_PaymentVerificationSucceed;
        Zarinpal.PaymentVerificationFailed -= Zarinpal_PaymentVerificationFailed;
    }

    private void Zarinpal_StoreInitialized()
    {
        Log("Store initialized");
    }

    private void Zarinpal_StoreInitializeFailed(string error)
    {
        LogError(error);
    }

    private void Zarinpal_PurchaseStarted()
    {
        Log("Purchase started");
    }

    private void Zarinpal_PurchaseFailedToStart(string error)
    {
        LogError("Purchase failed to start : "+ error);
    }

    private void Zarinpal_PurchaseSucceed(string productID, string authority)
    {
        if (ObscuredPrefs.GetString(db.PpsUserCode).ToLower().Contains("faryar"))
        {
          Loadingpanel.gameObject.SetActive(false);
          Succesfullpanel.gameObject.SetActive(true);

          Token.text = authority;
          if (productID == "Book")
          {
           productName.text = "نسخه کامل کتاب";
           ObscuredPrefs.SetInt(PpsBOL,1);
           ObscuredPrefs.SetString(PpsBOLToken, authority);
           ObscuredPrefs.Save();
           db.SendPpsBOLtoServer();
           db.PanelUnlockBook.gameObject.SetActive(false);

          }
          else if (productID == "Game")
          {
           productName.text = "مدل حرفه ای بازی";
           ObscuredPrefs.SetInt(PpsGOL, 1);
           ObscuredPrefs.SetString(PpsGOLToken, authority);
           ObscuredPrefs.Save();
           db.SendPpsGOLtoServer();
           db.PanelUnlockGame.gameObject.SetActive(false);

          }
            //Log(string.Format("Purchase success : productID : {0} , authority : {1} ", productID, authority));
        }
        else
        {
            db.MessageFaryar.gameObject.SetActive(true);
            db.TextMessageFaryar.text = "کد معرف خود را ایجاد نکرده اید";
        }
    }

    private void Zarinpal_PurchaseFailed()
    {
        Loadingpanel.gameObject.SetActive(false);
        Failedpanel.gameObject.SetActive(true);

        LogError("Purchase failed");
    }

    private void Zarinpal_PurchaseCanceled()
    {
        Log("Purchase canceled by user");
    }

    private void Zarinpal_PaymentVerificationStarted(string authority)
    {
        Log("Start verifying purchase for : url : " + authority);
    }

    private void Zarinpal_PaymentVerificationSucceed(string refID)
    {
        Log("Purchase verification success : refid : " + refID);
    }

    private void Zarinpal_PaymentVerificationFailed()
    {
        LogError("Purchase verification failed");
    }

    public void Initialize()
    {
        Zarinpal.Initialize();
    }

    public void Purchase(string productID)
    {
        Loadingpanel.gameObject.SetActive(true);
        if(productID=="Book")
        {
            m_amount = db.PpsBookfee;
            m_desc = "خرید نسخه کامل کتاب";
           // productName.text = "نسخه کامل کتاب";
        }
        else if(productID=="Game")
        {
            m_amount = db.PpsGamefee;
            m_desc = "خرید مدل حرفه ای بازی";
           // productName.text = "مدل حرفه ای بازی";
        }

        long price;
        long.TryParse(m_amount, out price);
        var desc = m_desc;
        Zarinpal.Purchase(price, desc, productID);
    }


    private void Log(string log)
    {
        Faryar.gameObject.SetActive(true);
        m_text.text += "\n"+DateTime.Now.ToLongTimeString()+"  : <color=#FFFFFFFF>" + log+"</color>";
    }

    private void LogError(string error)
    {
        Faryar.gameObject.SetActive(true);
        m_text.text += "\n" + DateTime.Now.ToLongTimeString() +"  : <color=#FF0000FF>" + error + "</color>";
    }
}
