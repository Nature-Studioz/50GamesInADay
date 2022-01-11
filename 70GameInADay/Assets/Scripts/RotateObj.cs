using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
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
        transform.Rotate(Input.GetAxisRaw("Vertical") * Speed, 0f, Input.GetAxisRaw("Horizontal") * -Speed,Space.World);
    }
}
