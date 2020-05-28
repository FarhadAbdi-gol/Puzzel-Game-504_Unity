using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OpenBookFree : MonoBehaviour
{
    #region variables

    [SerializeField] Button openBtnFree = null;
    [SerializeField] GameObject openedBookFree = null;
    [SerializeField] GameObject closedBookFree = null;
    [SerializeField] GameObject frontofBookFree = null;
    public AudioSource audioSourceBook;
    public AudioClip Cover;

    private Vector3 rotationVector;

    private Quaternion startRotation;

    private bool isOpenClickedFree=false;
    private bool isCloseClickedFree=false;

    private DateTime startTime;
    private DateTime endTime;

    #endregion

    private void Awake()
    {
        AppEventsFree.CloseBookFree += new EventHandler(closeBookBtnFree_Click);
    }

    #region start 


    private void Start()
    {
        startRotation = transform.rotation;

        if (openBtnFree != null)
        { 
            openBtnFree.onClick.AddListener(() => openBtnFree_Click());
        }
    }

    #endregion

    #region upadte
    void Update()
    {
        if ((isOpenClickedFree) || (isCloseClickedFree))
        {
            frontofBookFree.transform.Rotate(rotationVector * Time.deltaTime);
            endTime = DateTime.Now;

            if (isOpenClickedFree)
            {
                if ((endTime - startTime).TotalSeconds >= 1)
                {
                    closedBookFree.gameObject.SetActive(false);
                    openedBookFree.gameObject.SetActive(true);
                    AppEventsFree.OpenBookFunctionFree();

                    Vector3 newRotation = new Vector3(startRotation.x, -180, startRotation.y);
                    frontofBookFree.transform.rotation = Quaternion.Euler(newRotation);
                    isOpenClickedFree = false;
                }
            }
            else if (isCloseClickedFree)
            {
                if ((endTime - startTime).TotalSeconds >= 1)
                {
                    Vector3 newRotation = new Vector3(startRotation.x, 0 , startRotation.y);
                    frontofBookFree.transform.rotation = Quaternion.Euler(newRotation);
                    isCloseClickedFree = false;
                }
            }
        }
    }

    #endregion

    #region open Button Click

    private void openBtnFree_Click()
    {
        isOpenClickedFree = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, -180, 0);
        PlayCover();
    }

    #endregion

    #region close book button click

    private void closeBookBtnFree_Click(object sender, EventArgs e)
    {
        isCloseClickedFree = true;
        if (closedBookFree != null)
        {
            closedBookFree.gameObject.SetActive(true);
        }
        if (openedBookFree != null)
        {
            openedBookFree.gameObject.SetActive(false);
        }
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, 180, 0);
        PlayCover();
    }

    #endregion
    public void PlayCover()
    {
        if (Cover != null && audioSourceBook != null)
        {
            audioSourceBook.PlayOneShot(Cover);
        }
    }
}
