using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutToMouse : MonoBehaviour
{
    public Transform Put;
    Vector3 Pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      
    }

    private void FixedUpdate()
    {
        Put.position = Vector3.MoveTowards(Put.position, new Vector3(Pos.x, Pos.y, Put.position.z), 0.1f);
    }
}
