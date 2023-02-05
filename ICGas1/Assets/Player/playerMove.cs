using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    private float speed = 6.0f;
    private float JumpForce = 5.0f;
    private Rigidbody rb;
    public bool isGround;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            rb.velocity = new Vector3(verticalInput * speed, rb.velocity.y, horizontalInput * -speed);

        if (Input.GetKey("space") && isGround==true)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag==("Floor"))
        {
            isGround = true;
            Debug.Log("onGround");
        }
       

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag==("Floor"))
        {
            isGround = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name==("DeathTrigger"))
        {
            SceneManager.LoadScene("Dead");
        }

        else if (other.gameObject.name == ("Trigger"))
        {
            SceneManager.LoadScene("Win");
        }

    }
}

