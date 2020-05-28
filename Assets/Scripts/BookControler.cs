
using UnityEngine;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Storage;

public class BookControler : MonoBehaviour
{
    #region public Variables
    public float speed;
    public float Xmin, Xmax, Ymin, Ymax, Zmin, Zmax;
    #endregion

    #region Private Variables
    private float h;
    private float v;
    private float z;
    #endregion

    #region Update
    void Update()
    {
          CheckKeyboardInput();
          Vector3 move = new Vector3(h, v, z) * speed * Time.deltaTime;
          transform.position += move;
          CheckBookOutOfBounds();
    }
    #endregion

    #region Book Canvas
    public void ZoomOut()
    {
        z = -1;
    }
    public void ZoomIn()
    {
        z = 1;
    }
    public void MoveUp()
    {
        v = 1;
    }
    public void MoveDown()
    {
        v = -1;
    }
    public void MoveRight()
    {
        h = 1;
    }
    public void MoveLeft()
    {
        h = -1;
    }
    public void StopMoving()
    {
        v = 0;
        h = 0;
        z = 0;
    }
    private void CheckKeyboardInput()
    {
        if(Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            ZoomIn();
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            ZoomOut();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
        }
        if (Input.GetKeyUp(KeyCode.KeypadPlus) || Input.GetKeyUp(KeyCode.KeypadMinus) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            StopMoving();
        }
    }
    private void CheckBookOutOfBounds()
    {
        transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, Xmin, Xmax),
                    Mathf.Clamp(transform.position.y, Ymin, Ymax),
                    Mathf.Clamp(transform.position.z, Zmin, Zmax)
                    );
    }

    

    #endregion
}