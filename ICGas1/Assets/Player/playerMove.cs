using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    [SerializeField] float JumpForce = 10.0f;
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
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.Translate(speed*Time.deltaTime,0f,0f);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Translate(0f, 0f, speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.Space) && isGround == true)
        {
            rb.transform.Translate(0f, JumpForce * Time.deltaTime, 0f);
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
}
