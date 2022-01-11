using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMover : MonoBehaviour
{
    public Transform Player;
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
        rb.velocity = transform.forward * 5;
        Vector3 Dir = Player.position - transform.position;
        var Rot = Quaternion.LookRotation(Dir);
        var Mov = Quaternion.Slerp(transform.rotation, Rot, 0.5f).eulerAngles;
        transform.eulerAngles = new Vector3(0f, Mov.y, transform.eulerAngles.z);
    }
}
