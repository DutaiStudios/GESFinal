using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    
    [SerializeField] ParticleSystem unlock_particle;
    [SerializeField] Collider unlock_collider;
    [SerializeField] grabInspect g_inspect;

    private bool hasplayed = false;

    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        unlock_particle.Pause();
        g_inspect.canmove = false;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {

            particleplay();
            g_inspect.canmove = true;
            unlock_collider.enabled = false;
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
}
