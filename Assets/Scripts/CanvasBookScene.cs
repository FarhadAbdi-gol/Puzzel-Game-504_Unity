
using UnityEngine;

public class CanvasBookScene : MonoBehaviour {

    MainMenu menu;

    #region Awake
    private void Awake()
    {
        menu =GameObject.Find("Coding504Canvas").gameObject.GetComponent<MainMenu>();
    }
    #endregion

    #region BackFree to Main
    public void BackofBookFreetoMainMenu()
    {
        
        menu.BookFlipFree.gameObject.SetActive(false);
        menu.CanvasBookFree.gameObject.SetActive(false);
        menu.Table.gameObject.SetActive(false);
        menu.Background.gameObject.SetActive(true);
        menu.Faryar.gameObject.SetActive(true);
        menu.StoryMenuHolder.gameObject.SetActive(true);
        menu.PlayBack();
    }
    #endregion

    #region BackFull to Main
    public void BackofBookFulltoMainMenu()
    {
        menu.BookFlipFull.gameObject.SetActive(false);
        menu.CanvasBookFull.gameObject.SetActive(false);
        menu.Table.gameObject.SetActive(false);
        menu.Background.gameObject.SetActive(true);
        menu.Faryar.gameObject.SetActive(true);
        menu.StoryMenuHolder.gameObject.SetActive(true);
        menu.PlayBack();
    }
    #endregion
}
