using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCollect : MonoBehaviour
{
    public float Speed;
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
        GetComponent<Mover>().Move(Input.GetAxisRaw("Horizontal") * Speed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
