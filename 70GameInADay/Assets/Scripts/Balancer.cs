using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balancer : MonoBehaviour
{
    public float Speed;
    public Rigidbody rb;
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
        rb.AddTorque(new Vector3(0f, 0f, Input.GetAxisRaw("Horizontal") * Speed));
    }
}
