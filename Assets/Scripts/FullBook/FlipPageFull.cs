using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using RTLTMPro;

public class FlipPageFull : MonoBehaviour
{

    #region variables

    private enum ButtonType
    {
        NextButtonFull,
        PrevButtonFull
    }
  

    [SerializeField] GameObject closeBookFull;

    [SerializeField] Button closeBtnFull=null;
    [SerializeField] Button nextBtnFull=null;
    [SerializeField] Button prevBtnFull=null;

    [SerializeField] RTLTextMeshPro FullbodyText1_1=null;
    [SerializeField] RTLTextMeshPro FullbodyText1_2=null;
    [SerializeField] RTLTextMeshPro FullbodyText2_1=null;
    [SerializeField] RTLTextMeshPro FullbodyText2_2=null;

    [SerializeField] RTLTextMeshPro FullfooterText1_1=null;
    [SerializeField] RTLTextMeshPro FullfooterText1_2=null;
    [SerializeField] RTLTextMeshPro FullfooterText2_1=null;
    [SerializeField] RTLTextMeshPro FullfooterText2_2=null;

    public AudioSource audioSourceBook;
    public AudioClip Flip;

    private bool isClicked;

    private DateTime startTime;
    private DateTime endTime;

    private Vector3 rotationVector;
    private Quaternion startRotation;

    #endregion

    #region start

    private void Start()
    {

        startRotation = transform.rotation;

        if (closeBtnFull != null)
            closeBtnFull.onClick.AddListener(() => closeBookBtnFull_Click());

        if (nextBtnFull != null)
            nextBtnFull.onClick.AddListener(() => turnOnePageBtnFull_Click(ButtonType.NextButtonFull));

        if (prevBtnFull != null)
            prevBtnFull.onClick.AddListener(() => turnOnePageBtnFull_Click(ButtonType.PrevButtonFull));
    }

    private void Awake()
    {
        AppEventsFull.OpenBookFull += new EventHandler(openBookBtnFull_Click);
    }

    #endregion

    #region update
    private void Update()
    {
        if (isClicked)
        {
            transform.Rotate(rotationVector * Time.deltaTime);

            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= .5f)
            {
                SetVisibleTextFull();
            }
            if ((endTime - startTime).TotalSeconds >= 1)
            {

                isClicked = false;
                transform.rotation = startRotation;
            }

        }
    }
    #endregion

    #region turn one page button click

    private void turnOnePageBtnFull_Click(ButtonType type)
    {
        isClicked = true;
        startTime = DateTime.Now;
      
        nextBtnFull.gameObject.SetActive(true);
        prevBtnFull.gameObject.SetActive(true);

        if (type == ButtonType.NextButtonFull)
        {

            rotationVector = new Vector3(0, -180, 0);

            SetFlipPageTextFull(PageFull.FullCurrentPage2, PageFull.FullCurrentPage2 + 1);

            PageFull.FullCurrentPage1 += 2;
            PageFull.FullCurrentPage2 += 2;
            PageFull pge = PageFull.RandomPageFull;

            if ((PageFull.FullCurrentPage1 >= pge.Pages.Count) || (PageFull.FullCurrentPage2 >= pge.Pages.Count))
            {
                nextBtnFull.gameObject.SetActive(false);
            }
        }
        else if (type == ButtonType.PrevButtonFull)
        {

            Vector3 newRotation = new Vector3(startRotation.x, -180, startRotation.z);
            transform.rotation = Quaternion.Euler(newRotation);

            rotationVector = new Vector3(0, 180, 0);

            SetFlipPageTextFull(PageFull.FullCurrentPage1 - 1, PageFull.FullCurrentPage1);

            PageFull.FullCurrentPage1 -= 2;
            PageFull.FullCurrentPage2 -= 2;

            if ((PageFull.FullCurrentPage1 <= 1) || (PageFull.FullCurrentPage2 <= 1))
            {
                prevBtnFull.gameObject.SetActive(false);
            }
        }

        PlayFlip();
    }

    #endregion

    #region open book button click

    private void openBookBtnFull_Click(object sender, EventArgs e)
    {
        PageFull pge = PageFull.GetRandomPageFull();
        PageFull.FullCurrentPage1 = 0;
        PageFull.FullCurrentPage2 = 1;
        if (nextBtnFull != null && prevBtnFull != null)
        {
            nextBtnFull.gameObject.SetActive(true);
            prevBtnFull.gameObject.SetActive(false);
        }
        SetVisibleTextFull();
    }

    #endregion

    #region close book button click

    private void closeBookBtnFull_Click()
    {
        AppEventsFull.CloseBookFunctionFull();
    }

    #endregion

    #region set  text

    private void SetVisibleTextFull()
    {
        PageFull pge = PageFull.RandomPageFull;

        string footer1 = "";
        string footer2 = "";
        string body1 = "";
        string body2 = "";

        if (PageFull.FullCurrentPage1 < pge.Pages.Count)
        {
            footer1 = String.Format("صفحه {0} از {1}", PageFull.FullCurrentPage1 + 1, pge.Pages.Count);
            body1 = pge.Pages[PageFull.FullCurrentPage1];
        }
        if (PageFull.FullCurrentPage2 < pge.Pages.Count)
        {
            footer2 = String.Format("صفحه {0} از {1}", PageFull.FullCurrentPage2 + 1, pge.Pages.Count);
            body2 = pge.Pages[PageFull.FullCurrentPage2];
        }

        FullfooterText1_1.text = footer1;
        FullfooterText2_1.text = footer2;
        FullbodyText1_1.text = body1;
        FullbodyText2_1.text = body2;
    }


    private void SetFlipPageTextFull(int rightPage, int leftPage)
    {
        PageFull pge = PageFull.RandomPageFull;

        string footerR = "";
        string footerL = "";
        string bodyR = "";
        string bodyL = "";


        if (rightPage < pge.Pages.Count)
        {
            footerR = String.Format("صفحه {0} از {1}", rightPage + 1, pge.Pages.Count);
            bodyR = pge.Pages[rightPage];
        }
        if (leftPage < pge.Pages.Count)
        {
            footerL = String.Format("صفحه {0} از {1}", leftPage + 1, pge.Pages.Count);
            bodyL = pge.Pages[leftPage];
        }

        FullfooterText1_2.text = footerL;
        FullfooterText2_2.text = footerR;
        FullbodyText1_2.text = bodyL;
        FullbodyText2_2.text = bodyR;
    }

    #endregion
    public void PlayFlip()
    {
        if (Flip != null && audioSourceBook != null)
        {
            audioSourceBook.PlayOneShot(Flip);
        }
    }
}
