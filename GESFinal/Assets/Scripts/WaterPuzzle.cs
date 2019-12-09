using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPuzzle : MonoBehaviour
{

    public int heat = 0;

    [SerializeField] ParticleSystem cool;
    [SerializeField] ParticleSystem mid;
    [SerializeField] ParticleSystem high;
    [SerializeField] GameObject triggerbox;
    [SerializeField] GameObject door;
    private float doorswing = 90;

    // Start is called before the first frame update

    void Start()
    {
        triggerbox.SetActive(false);
        cool.Pause();
        mid.Pause();
        high.Pause();
    }
    // Update is called once per frame
    void Update()
    {
        HeatCheck();
    }

    void HeatCheck()
    {
        if (heat == 0 || heat == -1 || heat == -2)
        {
            cool.Play();
        }
        if (heat == 1)
        {
            cool.Stop();
            mid.Play();
        }
        if (heat >= 2)
        {
            cool.Stop();
            mid.Stop();
            high.Play();
            triggerbox.SetActive(true);
 
        }
    }


}
