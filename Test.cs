using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello World!");
        // To destroy an object in 3 seconds
        // Destroy(gameObject,3f);

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame.
    void Update()
    {

        //This code works when space bar is pressed.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Destroy(gameObject);

            // Adds Force in upward direction when space is clicked.
            rb.AddForce(Vector3.up * 500);

        }

        // Adds velocity to the object. The object keeps on moving forward. 
        rb.velocity = Vector3.forward * 20f;


    }


    //This function destroys object when mouse is clicked.
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
