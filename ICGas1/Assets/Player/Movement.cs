using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    private Rigidbody rb;
    public float playerR;
    public float playerL;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
       if (Input.GetKey(KeyCode.Space))
       {
            rb.velocity = new Vector3(0,10f,0);
       }

       else if (Input.GetKey(KeyCode.D))
       {
            rb.velocity = new Vector3(playerR, 0, 0);
       }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(playerL, 0, 0);
        }

    }
}
