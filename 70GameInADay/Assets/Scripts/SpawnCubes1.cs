using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes1 : MonoBehaviour
{
    public float MinX, MaxX;
    public Spawner spawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            float Rand = Random.Range(0.24f, 1f);
            yield return new WaitForSeconds(1);
            GetComponent<Spawner>().SpawnObj(new Vector3(Random.Range(MinX, MaxX), transform.position.y, transform.position.z), Quaternion.identity,5);
            spawn.SpawnObj(new Vector3(-10, Random.Range(MinX, MaxX), transform.position.z), Quaternion.identity, 20);
        }
    }
}
