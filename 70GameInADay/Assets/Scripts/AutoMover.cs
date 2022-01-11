using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour
{
    public Rigidbody rb;
    public float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(X, Y, Z);
    }
}
