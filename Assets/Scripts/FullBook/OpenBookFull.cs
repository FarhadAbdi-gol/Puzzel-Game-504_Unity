using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OpenBookFull : MonoBehaviour
{
    #region variables

    [SerializeField] Button openBtnFull = null;
    [SerializeField] GameObject openedBookFull = null;
    [SerializeField] GameObject closedBookFull = null;
    [SerializeField] GameObject frontofBookFull = null;
    public AudioSource audioSourceBook;
    public AudioClip Cover;

    private Vector3 rotationVector;

    private Quaternion startRotation;

    private bool isOpenClickedFull = false;
    private bool isCloseClickedFull = false;

    private DateTime startTime;
    private DateTime endTime;

    #endregion

    private void Awake()
    {
        AppEventsFull.CloseBookFull += new EventHandler(closeBookBtnFull_Click);
    }

    #region start 
    private void Start()
    {
        startRotation = frontofBookFull.transform.rotation;

        if (openBtnFull != null)
        {
            openBtnFull.onClick.AddListener(() => openBtnFull_Click());
        }
    }

    #endregion

    #region upadte
    void Update()
    {
        if ((isOpenClickedFull) || (isCloseClickedFull))
        {
            frontofBookFull.transform.Rotate(rotationVector * Time.deltaTime);
            endTime = DateTime.Now;

            if (isOpenClickedFull)
            {
                if ((endTime - startTime).TotalSeconds >= 1f)
                {
                    closedBookFull.gameObject.SetActive(false);
                    openedBookFull.gameObject.SetActive(true);
                    AppEventsFull.OpenBookFunctionFull();

                    Vector3 newRotation = new Vector3(startRotation.x, -180, startRotation.y);
                    frontofBookFull.transform.rotation = Quaternion.Euler(newRotation);
                    isOpenClickedFull = false;
                }
            }
            else if (isCloseClickedFull)
            {
                if ((endTime - startTime).TotalSeconds >= 1)
                {
                    Vector3 newRotation = new Vector3(startRotation.x, 0, startRotation.y);
                    frontofBookFull.transform.rotation = Quaternion.Euler(newRotation);
                    isCloseClickedFull = false;
                }
            }

        }
    }

    #endregion

    #region open Button Click

    private void openBtnFull_Click()
    {
        isOpenClickedFull = true;
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, -180, 0);
        PlayCover();
    }

    #endregion

    #region close book button click

    public void closeBookBtnFull_Click(object sender, EventArgs e)
    {
        isCloseClickedFull = true;
        if (closedBookFull != null)
        {
            closedBookFull.gameObject.SetActive(true);
        }
        if (openedBookFull != null)
        {
            openedBookFull.gameObject.SetActive(false);
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
