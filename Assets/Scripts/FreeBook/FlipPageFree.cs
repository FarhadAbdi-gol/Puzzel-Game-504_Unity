using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using RTLTMPro;


public class FlipPageFree : MonoBehaviour
{

    #region variables

    private enum ButtonType
    {
        NextButtonFree,
        PrevButtonFree
    }

    [SerializeField] GameObject closeBook;

    [SerializeField] Button closeBtnFree=null;
    [SerializeField] Button nextBtnFree=null;
    [SerializeField] Button prevBtnFree=null;

    [SerializeField] RTLTextMeshPro FreebodyText1_1=null;
    [SerializeField] RTLTextMeshPro FreebodyText1_2=null;
    [SerializeField] RTLTextMeshPro FreebodyText2_1=null;
    [SerializeField] RTLTextMeshPro FreebodyText2_2=null;

    [SerializeField] RTLTextMeshPro FreefooterText1_1=null;
    [SerializeField] RTLTextMeshPro FreefooterText1_2=null;
    [SerializeField] RTLTextMeshPro FreefooterText2_1=null;
    [SerializeField] RTLTextMeshPro FreefooterText2_2=null;

    public AudioSource audioSourceBook;
    public AudioClip Flip;

    private bool isClickedFree;

    private DateTime startTime;
    private DateTime endTime;

    private Vector3 rotationVector;
    private Quaternion startRotation;

    #endregion


    #region start
   
    private void Start()
    {
        
        startRotation = transform.rotation;

        if (closeBtnFree != null)
            closeBtnFree.onClick.AddListener(() => closeBookBtnFree_Click());

        if (nextBtnFree != null)
            nextBtnFree.onClick.AddListener(() => turnOnePageBtnFree_Click(ButtonType.NextButtonFree));

        if (prevBtnFree != null)
            prevBtnFree.onClick.AddListener(() => turnOnePageBtnFree_Click(ButtonType.PrevButtonFree));
    }

    private void Awake()
    {
        AppEventsFree.OpenBookFree += new EventHandler(openBookBtnFree_Click);
    }

    #endregion

    #region update
    private void Update()
    {
        if (isClickedFree)
        {
            transform.Rotate(rotationVector * Time.deltaTime);

            endTime = DateTime.Now;
            if ((endTime - startTime).TotalSeconds >= .5f)
            {
                SetVisibleTextFree();
            }
            if ((endTime - startTime).TotalSeconds >= 1)
            {
               
                isClickedFree = false;
                transform.rotation = startRotation;
            }

        }
    }
    #endregion

    #region turn one page button click

    private void turnOnePageBtnFree_Click(ButtonType type)
    {
        isClickedFree = true;
        startTime = DateTime.Now;
        nextBtnFree.gameObject.SetActive(true);
        prevBtnFree.gameObject.SetActive(true);

        if (type == ButtonType.NextButtonFree)
        {
           
            rotationVector = new Vector3(0, -180, 0);

            SetFlipPageTextFree(PageFree.FreeCurrentPage2, PageFree.FreeCurrentPage2 + 1);
        
            PageFree.FreeCurrentPage1 += 2;
            PageFree.FreeCurrentPage2 += 2;
            PageFree pge= PageFree.RandomPageFree;

            if ((PageFree.FreeCurrentPage1 >= pge.Pages.Count) || (PageFree.FreeCurrentPage2 >= pge.Pages.Count))
            {
                nextBtnFree.gameObject.SetActive(false);
            }
        }
        else if (type == ButtonType.PrevButtonFree)
        {
           
            Vector3 newRotation = new Vector3(startRotation.x, -180, startRotation.z);
            transform.rotation = Quaternion.Euler(newRotation);

            rotationVector = new Vector3(0, 180, 0);

            SetFlipPageTextFree(PageFree.FreeCurrentPage1 - 1, PageFree.FreeCurrentPage1);

            PageFree.FreeCurrentPage1 -= 2;
            PageFree.FreeCurrentPage2 -= 2;

            if ((PageFree.FreeCurrentPage1 <= 1) || (PageFree.FreeCurrentPage2 <= 1))
            {
                prevBtnFree.gameObject.SetActive(false);
            }
        }

        PlayFlip();
    }

    #endregion

    #region open book button click

    private void openBookBtnFree_Click(object sender, EventArgs e)
    {
        PageFree pge = PageFree.GetRandomPageFree();
        PageFree.FreeCurrentPage1 = 0;
        PageFree.FreeCurrentPage2 = 1;
        if (nextBtnFree != null && prevBtnFree !=null)
        {
            nextBtnFree.gameObject.SetActive(true);
            prevBtnFree.gameObject.SetActive(false);
        }
        SetVisibleTextFree();
    }

    #endregion

    #region close book button click

    private void closeBookBtnFree_Click()
    {
        AppEventsFree.CloseBookFunctionFree();
    }

    #endregion

    #region set  text

    private void SetVisibleTextFree()
    {
        PageFree pge = PageFree.RandomPageFree;

        string footer1 = "";
        string footer2 = "";
        string body1 = "";
        string body2 = "";

        if (PageFree.FreeCurrentPage1 < pge.Pages.Count)
        {
            footer1 = String.Format("صفحه {0} از {1}", PageFree.FreeCurrentPage1 + 1, pge.Pages.Count);
            body1 = pge.Pages[PageFree.FreeCurrentPage1];
        }
        if (PageFree.FreeCurrentPage2 < pge.Pages.Count)
        {
            footer2 = String.Format("صفحه {0} از {1}", PageFree.FreeCurrentPage2 + 1, pge.Pages.Count);
            body2 = pge.Pages[PageFree.FreeCurrentPage2];
        }

        FreefooterText1_1.text = footer1;
        FreefooterText2_1.text = footer2;
        FreebodyText1_1.text = body1;
        FreebodyText2_1.text = body2;
    }


    private void SetFlipPageTextFree(int rightPage,int leftPage)
    {
        PageFree pge = PageFree.RandomPageFree;

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

        FreefooterText1_2.text = footerL;
        FreefooterText2_2.text = footerR;
        FreebodyText1_2.text = bodyL;
        FreebodyText2_2.text = bodyR;
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
