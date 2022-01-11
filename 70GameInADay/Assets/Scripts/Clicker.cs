using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public GameObject Ob;

    Vector3 worldPosition;

   void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 4.607702f;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        if (Input.GetMouseButton(0))
        {
            Instantiate(Ob, worldPosition, Quaternion.identity);
        }
    }


}
