using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{
    [SerializeField] float speed = 4.0f;
    [SerializeField] float JumpForce = 6.0f;
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

        if (Input.GetKey(KeyCode.Space) && isGround == true)
        {
            //rb.transform.Translate(0f, JumpForce * Time.deltaTime, 0f);
            rb.velocity = new Vector3(0f, JumpForce, 0f);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;

    }

    private void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Dead");
    }
}

