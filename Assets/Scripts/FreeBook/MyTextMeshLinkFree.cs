using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class MyTextMeshLinkFree : MonoBehaviour, IPointerClickHandler
{
    TextMeshProUGUI textMeshProFree;
    Canvas canvas;
    Camera _camera;
    FaryarDataBase FDB;

    void Awake()
    {
        FDB = GameObject.Find("DatabaseControler").gameObject.GetComponent<FaryarDataBase>();
        textMeshProFree = gameObject.GetComponent<TextMeshProUGUI>();
        canvas = gameObject.GetComponentInParent<Canvas>();
        _camera = gameObject.GetComponentInParent<Camera>();

        if (canvas.renderMode == RenderMode.ScreenSpaceOverlay)
        {
            _camera = null;
        }
        else
        {
            _camera = canvas.worldCamera;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        int linkIndexFree = TMP_TextUtilities.FindIntersectingLink(textMeshProFree, Input.mousePosition, _camera);
        if (linkIndexFree != -1)
        {
            TMP_LinkInfo linkInfoFree = textMeshProFree.textInfo.linkInfo[linkIndexFree];
            switch (linkInfoFree.GetLinkID())
            {
                case "A":
                    { 
                    Application.OpenURL("https://faryarteam.ir");
                    }
                    break;
                case "B":
                    {
                    Application.OpenURL("https://www.linkedin.com/in/farhad-abdi-gol-30083984");
                    }
                    break;
                case "C":
                    {
                    Application.OpenURL("https://www.instagram.com/faryar_team");
                    }
                    break;
                case "D":
                    {
                    Application.OpenURL("https://www.youtube.com/channel/UCStnXW9NQdF9yEg8Ugcb9ZA/about?view_as=subscriber");
                    }
                    break;
                case "F":
                    {
                        Application.OpenURL("https://www.aparat.com/Faryar_Team");
                    }
                    break;
                case "MessageFaryar":
                    {
                        Application.OpenURL(FDB.link.ToString());
                    }
                    break;
            }
        }
    }
}