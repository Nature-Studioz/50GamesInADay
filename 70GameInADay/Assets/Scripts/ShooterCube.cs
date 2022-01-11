using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterCube : MonoBehaviour
{
    public Transform ShootSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Spawner>().SpawnObj(ShootSpawn.position, Quaternion.identity, 5);
        }
    }
}
