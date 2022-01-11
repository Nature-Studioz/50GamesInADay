using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ZMover : MonoBehaviour
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
        float Z = Input.GetAxisRaw("Vertical") * Speed;
        float X = Input.GetAxisRaw("Horizontal") * Speed;
        rb.velocity = new Vector3(X, rb.velocity.y, Z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
