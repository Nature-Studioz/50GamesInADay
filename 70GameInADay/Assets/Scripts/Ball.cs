using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed;
    public float OldSpeed;
    public Rigidbody rb;
    public Vector2 Move;
    Vector2 LastVel;


    bool HasDo = true;
    // Start is called before the first frame update

    
    void Start()
    {

       
        int RandX = Random.Range(-1, 2);
        int RandY = Random.Range(-1, 2);
        if(RandX == 0)
        {
            RandX = 1;
        }
        if(RandY == 0)
        {
            RandY = 1;
        }
        Move = new Vector2(RandX, RandY) * Speed;
    }

    private void Update()
    {

       
            LastVel = rb.velocity;
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (HasDo)
        {
            rb.velocity = Move;
        }
    }

    public void Reflect(Vector2 Normal)
    {
        
            var Vel = LastVel.magnitude;
        
        var Direction = Vector2.Reflect(LastVel.normalized, Normal);
        Move = Direction * Mathf.Max(Vel, 5);
      
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if (HasDo)
        {
            Reflect(collision.contacts[0].normal);
        }
      

 
    }
}
