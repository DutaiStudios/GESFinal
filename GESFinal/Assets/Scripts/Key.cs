using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    [SerializeField] grabInspect gik;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lock")
        {
            gik.canmove = false;
        }
    }
}
