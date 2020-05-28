using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class MyTextMeshLinkFull : MonoBehaviour, IPointerClickHandler
{
    TextMeshProUGUI textMeshProFull;
    Canvas canvas;
    Camera _camera;


    void Awake()
    {
        textMeshProFull = gameObject.GetComponent<TextMeshProUGUI>();
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
        int linkIndexFull = TMP_TextUtilities.FindIntersectingLink(textMeshProFull, Input.mousePosition, _camera);
        if (linkIndexFull != -1)
        {
            TMP_LinkInfo linkInfoFull = textMeshProFull.textInfo.linkInfo[linkIndexFull];
            switch (linkInfoFull.GetLinkID())
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
            }
        }
    }
}