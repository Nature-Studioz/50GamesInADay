using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCyli : MonoBehaviour
{
    public Transform Cy;
    public Vector3 StartPos;
    public Vector3 StartScale;
    public Quaternion StartRot;
    public GameObject Beam;

    // Start is called before the first frame update
    void Start()
    {
        StartScale = Cy.localScale;
        StartRot = Cy.transform.rotation;
        StartPos = Cy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion Rot = new Quaternion(0f, 0f, 90f, 0f);
            GameObject o = Instantiate(Beam, StartPos, StartRot);
            o.transform.rotation = StartRot;
            o.transform.localScale = StartScale;
        }
    }
}
