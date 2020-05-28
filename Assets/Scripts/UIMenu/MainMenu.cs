// In The Name of Allah

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using CodeStage.AntiCheat.Storage;

public class MainMenu : MonoBehaviour
{
    #region public_Variables
    
    public GameObject MainMenuHolder, StoryMenuHolder, RelationUsHolder, VocabularyHolder, GameSwitchHolder, GameMenuLevelHolder, GameMenuLevelHolderHigh;
    public GameObject NeworOldCodeUser, Login, DefinePassword, Recovery;
    public GameObject CheckPaybagMenu, CreateUserCodeMenu, PayBagStoryMenu, SaveDataPanelHolder, SendEmailPanelHolder, SettingMenuHolder;
    public GameObject Faryar, Background, Table;
    public GameObject BookFlipFree, CanvasBookFree, BookFlipFull, CanvasBookFull;

    public Button ButtonPayBagGame, ButtonOnlineGame, ButtonPayBagBook, ButtonOnlineBook;
    public Button ButtonPayBook, ButtonPayBookBazzar, ButtonPayGame, ButtonPayGameBazzar;

    public AudioClip Back, Click;
    public AudioSource audioSourceBtn;

   
    #endregion

    FaryarDataBase db;

    private void Awake()
    {
        db = gameObject.GetComponentInChildren<FaryarDataBase>();
    }

    #region Sound
    public void PlayClick()
    {
        if (Click != null && audioSourceBtn != null)
        {
            audioSourceBtn.PlayOneShot(Click);
        }
    }
    public void PlayBack()
    {
        if (Back != null && audioSourceBtn != null)
        {
            audioSourceBtn.PlayOneShot(Back);
        }
    }
    #endregion

    #region Story_Menu
  
    public void Story_Button()
    {
        PlayClick();
        MainMenuHolder.gameObject.SetActive(false);
        StoryMenuHolder.gameObject.SetActive(true);
        Faryar.gameObject.SetActive(true);
      
        db.CheckOpenBook();
    }

    public void BackFromStory_ButtonToMenuStart()
    {
        PlayBack();
        StoryMenuHolder.gameObject.SetActive(false);
        MainMenuHolder.gameObject.SetActive(true);
        Faryar.gameObject.SetActive(false);
    }

    public void PayBagStory_Button()
    {
        PlayClick();
        if(ObscuredPrefs.GetInt(db.PpsCreateCode) == 0)
        {
            NeworOldCodeUser.gameObject.SetActive(true);
            StoryMenuHolder.gameObject.SetActive(false);
        }
        else if(ObscuredPrefs.GetInt(db.PpsCreateCode) > 0)
        {
            NeworOldCodeUser.gameObject.SetActive(false);
            CreateUserCodeMenu.gameObject.SetActive(false);
            StoryMenuHolder.gameObject.SetActive(false);
            CheckPaybagMenu.gameObject.SetActive(false);
            Login.gameObject.SetActive(false);
            DefinePassword.gameObject.SetActive(false);
            PayBagStoryMenu.gameObject.SetActive(true);
            db.SetDataPaybag();
        }
    }

    public void SettingStory_Button()
    {
        PlayClick();
        SettingMenuHolder.gameObject.SetActive(true);
    }

    public void FreeBook_Button()
    {
        PlayClick();
        Background.gameObject.SetActive(false);
        Faryar.gameObject.SetActive(false);
        StoryMenuHolder.gameObject.SetActive(false);
        Table.gameObject.SetActive(true);
        CanvasBookFree.gameObject.SetActive(true);
        BookFlipFree.gameObject.SetActive(true);
    }

    public void FullBook_Button()
    {
        PlayClick();
        Background.gameObject.SetActive(false);
        Faryar.gameObject.SetActive(false);
        StoryMenuHolder.gameObject.SetActive(false);
        Table.gameObject.SetActive(true);
        CanvasBookFull.gameObject.SetActive(true);
        BookFlipFull.gameObject.SetActive(true);
    }

    #endregion

    #region PayBagMenu
    public void BackOfPayBagMenu_Button()
    {
        PlayBack();
        PayBagStoryMenu.gameObject.SetActive(false);
        StoryMenuHolder.gameObject.SetActive(true);
        db.StartCoroutine(db.SendCashPaybagToServer());
    }
    #endregion

    #region Vocabulary_Menu
    public void Vocabulary_Button()
    {
        PlayClick();
        MainMenuHolder.gameObject.SetActive(false);
        VocabularyHolder.gameObject.SetActive(true);
    }
    public void BackFromVocabulary_ButtonToMenuStart()
    {
       PlayBack();
        VocabularyHolder.gameObject.SetActive(false);
        MainMenuHolder.gameObject.SetActive(true);
    }
    #endregion

    #region Relation_Menu
    public void Relation_Button()
    {
        PlayClick();
        MainMenuHolder.gameObject.SetActive(false);
        RelationUsHolder.gameObject.SetActive(true);
    }
    public void BackFromRelation_ButtonToMenuStart()
    {
        PlayBack();
        RelationUsHolder.gameObject.SetActive(false);
        MainMenuHolder.gameObject.SetActive(true);
    }
    public void Instagram_Button()
    {
       PlayClick();
        Application.OpenURL("https://www.instagram.com/faryar_team/");
    }
    public void SiteofFaryarTeam_Button()
    {
       PlayClick();
        Application.OpenURL("https://www.FaryarTeam.ir/");
    }
    public void LinkedIn_Button()
    {
        PlayClick();
        Application.OpenURL("https://www.linkedin.com/in/farhad-abdi-gol-30083984/");
    }
    public void YouTube_Button()
    {
       PlayClick();
        Application.OpenURL("https://www.youtube.com/channel/UCStnXW9NQdF9yEg8Ugcb9ZA/about?view_as=subscriber");
    }
    public void Aparat_Button()
    {
        PlayClick();
        Application.OpenURL("https://www.aparat.com/Faryar_Team");
    }

    #endregion

    #region Game_Menu

    public void Game_Button()
    {
        PlayClick();
        Faryar.gameObject.SetActive(true);
        GameSwitchHolder.gameObject.SetActive(true);
        MainMenuHolder.gameObject.SetActive(false);

        db.CheckOpenGame();
    }
    public void BackofSwitchMenutoMainMenu()
    {
        PlayBack();
        Faryar.gameObject.SetActive(false);
        GameSwitchHolder.gameObject.SetActive(false);
        MainMenuHolder.gameObject.SetActive(true);
    }
    #endregion

    #region Go to Amator Game
    public void GoToAmatorGameButton()
    {
        PlayClick();
        Faryar.gameObject.SetActive(false);
        GameMenuLevelHolder.gameObject.SetActive(true);
        GameSwitchHolder.gameObject.SetActive(false);
    }
    #endregion

    #region Go to High Game 
    public void GoToHighGameButton()
    {
        PlayClick();
        Faryar.gameObject.SetActive(false);
        GameMenuLevelHolderHigh.gameObject.SetActive(true);
        GameSwitchHolder.gameObject.SetActive(false);
    }
    #endregion

}
