using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObj(Vector3 Position,Quaternion Rotation,float Time = 0)
    {
        GameObject Ob = Instantiate(Spawn, Position, Rotation) as GameObject;
        Destroy(Ob, Time);
    }
}
