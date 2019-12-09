using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterReset : MonoBehaviour
{

    [SerializeField] WaterPuzzle wpuzz;
    [SerializeField] GameObject nozz1;
    [SerializeField] GameObject nozz2;
    [SerializeField] GameObject nozz3;
    [SerializeField] GameObject nozz4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        wpuzz.heat = 0;
        nozz1.SetActive(false);
        nozz2.SetActive(false);
        nozz3.SetActive(false);
        nozz4.SetActive(false);
    }
}
