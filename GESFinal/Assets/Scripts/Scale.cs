using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scale : MonoBehaviour
{

    [SerializeField] Text weight_text;
    [SerializeField] CharacterController c_control;
    [SerializeField] Key keydisable;
    [SerializeField] Lock lockdisable;

    private bool keyweight = false;
    private bool lockweight = false;


    private string curweight = "0";

    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        weight_text.text = curweight + "lb / 4lb";

        if (keyweight == true && lockweight == true)
        {
            curweight = "4";
            c_control.escapeval = "positive!";
            keydisable.enabled = false;
            lockdisable.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            curweight = ".5";
            keyweight = true;
        }

        if (collision.gameObject.tag == "Lock")
        {
            curweight = "3.5";
            lockweight = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            curweight = "0";
            keyweight = false;
        }

        if (collision.gameObject.tag == "Lock")
        {
            curweight = "0";
            lockweight = false;
        }
    }
}
