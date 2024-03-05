using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float moveSpeed = 5f;
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
            rb.AddForce(Vector3.forward * moveSpeed);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * moveSpeed);
        }
    }
}
