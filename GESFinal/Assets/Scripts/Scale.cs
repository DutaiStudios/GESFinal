using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scale : MonoBehaviour
{

    [SerializeField] Text weight_text;
    [SerializeField] CharacterController c_control;
    [SerializeField] Text hint_text;
    [SerializeField] Text weight_text2;
    [SerializeField] AudioSource doorsound;


    [SerializeField] GameObject[] weighed_objects;
    WeightValue totalval;
    private float correctweight = 4;
    private float currweight = 0;
    private float currweight2 = 0;
    private bool dooropen = false;
    private float doorswing = 90;


    [Header("Weighed Objects")]

    [SerializeField] WeightValue Key_weight;
    [SerializeField] WeightValue Lock_weight;
    [SerializeField] WeightValue Box1_weight;
    [SerializeField] WeightValue Box2_weight;
    [SerializeField] WeightValue me_weight;
    [SerializeField] GameObject door;



    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
        weight_text.text =  currweight + "lb / 4lb";
        hint_text.text = "Be precise.";

        if (currweight == correctweight)
        {
            if (dooropen == false)
            {
                door.transform.Rotate(0,doorswing,0);
                dooropen = true;

            }
            else if (dooropen == true)
            {

            }

        }

        weight_text2.text = currweight2 + "lb / 35lb";

        if (currweight2 == 35)
        {
            SceneManager.LoadScene("Ending");
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key")
        {
            currweight += Key_weight.Weight;
        }

        if (collision.gameObject.name == "Padlock")
        {
            currweight += Lock_weight.Weight;
        }
        
        if (collision.gameObject.name == "L_Box")
        {
            currweight += Box1_weight.Weight;
            currweight2 += Box1_weight.Weight;
        }

        if (collision.gameObject.name == "S_Box")
        {
            currweight += Box2_weight.Weight;
            currweight2 += Box2_weight.Weight;
        }

        if (collision.gameObject.name == "Player")
        {
            currweight2 += me_weight.Weight;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Key")
        {
            currweight -= Key_weight.Weight;
        }

        if (collision.gameObject.name == "Padlock")
        {
            currweight -= Lock_weight.Weight;
        }

        if (collision.gameObject.name == "L_Box")
        {
            currweight -= Box1_weight.Weight;
            currweight2 -= Box1_weight.Weight;
        }

        if (collision.gameObject.name == "S_Box")
        {
            currweight -= Box2_weight.Weight;
            currweight2 -= Box2_weight.Weight;
        }

        if (collision.gameObject.name == "Player")
        {
            currweight2 -= me_weight.Weight;
        }
    }



}
