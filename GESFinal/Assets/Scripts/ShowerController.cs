using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerController : MonoBehaviour
{

    [SerializeField] GameObject TrueRed;
    [SerializeField] GameObject TrueBlue;
    [SerializeField] WaterPuzzle w_puzz;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hothandle")
        {
            w_puzz.heat++;
            Destroy(collision.gameObject);

            TrueRed.SetActive(true);

        }

        if (collision.gameObject.tag == "ColdHandle")
        {
            w_puzz.heat--;
            Destroy(collision.gameObject);

            TrueBlue.SetActive(true);

        }
    }
}

