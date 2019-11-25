using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;
    public bool isGrounded = true;
    public Text hasescape;

    public string escapeval = "negative";

    public float tempjumptimer = 0;
    //TEMPJUMPTIMER is a placeholder

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        TextUpdate();

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }

        if (isGrounded == false)
        {
            tempjumptimer++;

            if (tempjumptimer >= 60)
            {
                isGrounded = true;
                tempjumptimer = 0;
            }
        }

    }

    public void TextUpdate()
    {
        hasescape.text = "Escape Status - " + escapeval;
    }

}
