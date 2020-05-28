using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Storage;

public class Setting : MonoBehaviour
{
    public Slider MasterVolumeSlider;
    public Slider BookVolumeSlider;
    public Slider ButtonVolumeSlider;
    public Slider SoundWVolumeSlider;
    public Slider MasterVolumeSliderHigh;
    public Slider BookVolumeSliderHigh;
    public Slider ButtonVolumeSliderHigh;
    public Slider SoundWVolumeSliderHigh;
    public AudioMixer AudioMixerObject;

    public GameObject SettingMenuHolder;
    public GameObject SettingMenuHolderHigh;
    public GameObject ExitPanelHolder;

    MainMenu menu;

    #region Awake
    private void Awake()
    {
        menu = GameObject.Find("Coding504Canvas").gameObject.GetComponent<MainMenu>();
    }
    #endregion

    private void Update()
    {
        #region Audio Slider
        if(SettingMenuHolder.activeInHierarchy)
        {
            MasterVolumeSlider.value = ObscuredPrefs.GetFloat("MasterVolumeValue");
            BookVolumeSlider.value = ObscuredPrefs.GetFloat("BookVolumeValue");
            ButtonVolumeSlider.value = ObscuredPrefs.GetFloat("ButtonVolumeValue");
            SoundWVolumeSlider.value = ObscuredPrefs.GetFloat("SoundWVolumeValue");
        }
        else if(SettingMenuHolderHigh.activeInHierarchy)
        {
            MasterVolumeSliderHigh.value = ObscuredPrefs.GetFloat("MasterVolumeValue");
            BookVolumeSliderHigh.value = ObscuredPrefs.GetFloat("BookVolumeValue");
            ButtonVolumeSliderHigh.value = ObscuredPrefs.GetFloat("ButtonVolumeValue");
            SoundWVolumeSliderHigh.value = ObscuredPrefs.GetFloat("SoundWVolumeValue");
        }

        #endregion

        #region Back Button Application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.PlayBack();
            ExitPanelHolder.gameObject.SetActive(true);
        }
        #endregion
    }


    #region SettingMenu

    public void SaveofSetting_Button()
    {
        ObscuredPrefs.Save();
        menu.PlayClick();
        if(SettingMenuHolder.activeInHierarchy)
        {
            SettingMenuHolder.gameObject.SetActive(false);
        }
        else if(SettingMenuHolderHigh.activeInHierarchy)
        {
            SettingMenuHolderHigh.gameObject.SetActive(false);
        }
    }
    public void DefultSettingofSetting_Button()
    {
        menu.PlayClick();
        if(SettingMenuHolder.activeInHierarchy)
        {
            MasterVolumeSlider.value = -3;
            BookVolumeSlider.value = -2;
            ButtonVolumeSlider.value = -1;
            SoundWVolumeSlider.value = 0;
        }
       else if(SettingMenuHolderHigh.activeInHierarchy)
        {
            MasterVolumeSliderHigh.value = -3;
            BookVolumeSliderHigh.value = -2;
            ButtonVolumeSliderHigh.value = -1;
            SoundWVolumeSliderHigh.value = 0;
        }
        ObscuredPrefs.Save();
    }

    public void VolumeMasterSlider_Button(float master)
    {
        AudioMixerObject.SetFloat("MasterVolume", master);
        if(SettingMenuHolder.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("MasterVolumeValue", MasterVolumeSlider.value);
        }
        else if(SettingMenuHolderHigh.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("MasterVolumeValue", MasterVolumeSliderHigh.value);
        }
        ObscuredPrefs.Save();
    }

    public void VolumeBookSlider_Button(float book)
    {
        AudioMixerObject.SetFloat("BookVolume", book);
        if (SettingMenuHolder.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("BookVolumeValue", BookVolumeSlider.value);
        }
        else if (SettingMenuHolderHigh.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("BookVolumeValue", BookVolumeSliderHigh.value);
        }

        ObscuredPrefs.Save();
    }

    public void VolumeButtonSlider_Button(float button)
    {
        AudioMixerObject.SetFloat("ButtonVolume", button);
        if (SettingMenuHolder.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("ButtonVolumeValue", ButtonVolumeSlider.value);
        }
        else if (SettingMenuHolderHigh.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("ButtonVolumeValue", ButtonVolumeSliderHigh.value);
        }

        ObscuredPrefs.Save();
    }

    public void VolumeSoundWSlider_Button(float sound)
    {
        AudioMixerObject.SetFloat("SoundWVolume", sound);
        if (SettingMenuHolder.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("SoundWVolumeValue", SoundWVolumeSlider.value);
        }
        else if (SettingMenuHolderHigh.activeInHierarchy)
        {
            ObscuredPrefs.SetFloat("SoundWVolumeValue", SoundWVolumeSliderHigh.value);
        }

        ObscuredPrefs.Save();
    }

    #endregion
    #region ExitPanel

    public void ExitNoButton()
    {
        menu.PlayClick();
        ExitPanelHolder.gameObject.SetActive(false);
    }
    public void ExitYesButton()
    {
        ObscuredPrefs.Save();
        menu.PlayBack();
        StartCoroutine(BackTime());
        Application.Quit();
    }
    public IEnumerator BackTime()
    {
        yield return new WaitForSeconds(1f);
    }
    #endregion

    private void OnApplicationQuit()
    {
        ObscuredPrefs.Save();
    }
}
