using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Lock lockthing;
    [SerializeField] Text opentext;
    public AudioSource doorsound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
      void OnMouseDown()
    {
            transform.Rotate(0, 90, 0);
            opentext.text = "";

    }
}

