using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class grabInspect : MonoBehaviour
{
    public Transform insp_pos;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = insp_pos.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
