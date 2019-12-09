using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScript : MonoBehaviour
{
    // Start is called before the first frame update

        public bool IsOpen = false;

        public float MovementVariable;
        

    void OnMouseDown()
    {
        if (IsOpen == true)
        {
            Close();
        }

        else if (IsOpen == false)
        {
            Open();
            Debug.Log("DrawerOpened");
        }
    }

    private void Close()
    {
        this.transform.Translate(0, 0, -MovementVariable);
        IsOpen = false;
    }

    private void Open()
    {
        this.transform.Translate(0, 0, MovementVariable);
        IsOpen = true;
    }

}
