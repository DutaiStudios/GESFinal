using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class grabInspect : MonoBehaviour
{
    public bool canmove;
    public Transform insp_pos;
    [SerializeField] Image reticle;

    void OnMouseDown()
    {
        if (canmove == true)
        {
            //work on adding Kinematic

            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = insp_pos.position;
            this.transform.parent = GameObject.Find("Destination").transform;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

        }
    }

    void OnMouseUp()
    {
        if (canmove == true)
        {   
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

    private void OnMouseOver()
    {
        
    }
}
