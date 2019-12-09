using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    
    [SerializeField] ParticleSystem unlock_particle;
    [SerializeField] Collider unlock_collider;
    [SerializeField] grabInspect g_inspect;
    [SerializeField] string KeyName;
    [SerializeField] GameObject door;
    private bool hasplayed = false;
    private bool unlockedonce = false;
    public bool lockoff;

    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        unlock_particle.Pause();
        g_inspect.canmove = false;

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == KeyName)
        {
            lockoff = true;
            particleplay();
            g_inspect.canmove = true;
            disablecollider();
            unlockedonce = true;
            GetComponent<Rigidbody>().useGravity = true;
            unlock_collider.enabled = true;
            hasplayed = true;


        }
    }

    void particleplay()
    {
        if (hasplayed == false)
        {
            unlock_particle.Play();
        }
        else
        {

        }
       
    }

    void disablecollider()
    {
        if (unlockedonce == false)
        {
        unlock_collider.enabled = false;
        }

    }
}
