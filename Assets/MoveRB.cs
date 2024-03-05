using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0,0,5);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-5,0,0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(5,0,0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(0, 0, -5);
        }
    }
}
