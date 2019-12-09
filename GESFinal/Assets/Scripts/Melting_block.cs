using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melting_block : MonoBehaviour
{

    [SerializeField] DrawerScript drawer;
    [SerializeField] grabInspect grab;
    [SerializeField] float movement;
    private bool hasmoved = false;
    private bool PickedUp;
    [SerializeField] GameObject thawedkey;
    // Start is called before the first frame update
    private void Start()
    {
        thawedkey.SetActive(false);
    }
    void Update()
    {

        if (grab.ispickedup == true)
        {
            PickedUp = true;
        }

        if (PickedUp == false)
        {
            CheckUse();
        }
        else if (PickedUp == true)
        {

        }

    }
    // Update is called once per frame
    void CheckUse()
    {
            if (drawer.IsOpen == true)
            {
                grab.canmove = true;
                if (hasmoved == false)
                {
                    this.transform.Translate(0, 0, movement);
                    hasmoved = true;
                }
            }

            else if (drawer.IsOpen == false)
            {
                if (hasmoved == true)
                {
                    this.transform.Translate(0, 0, -movement);
                    hasmoved = false;
                }
            }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "TrigOb")
        {
            thawedkey.SetActive(true);
            Destroy(gameObject);
        }
    }

}
