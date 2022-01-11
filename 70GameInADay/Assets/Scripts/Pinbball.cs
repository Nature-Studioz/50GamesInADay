using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinbball : MonoBehaviour
{
    public Transform Pin1;
    public Transform Pin2;
    public Vector3 Target1, Target2, Start1, Start2;
    public float Speed;
    bool CanMove = false;
    // Start is called before the first frame update
    void Start()
    {
        Start1 = Pin1.position;
        Start2 = Pin2.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !CanMove)
        {
            CanMove = true;
        }
    }

    private void FixedUpdate()
    {
        if (CanMove)
        {
            Pin1.position = Vector3.Lerp(Pin1.position, Start1, Speed);
            Pin2.position = Vector3.Lerp(Pin2.position, Start2, Speed);
            
            
        }
    }

    
}
