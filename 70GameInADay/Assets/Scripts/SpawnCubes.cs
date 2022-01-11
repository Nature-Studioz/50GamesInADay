using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public float MinX, MaxX;
    public float Timer = 5;
    public float Time = 1;
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
            yield return new WaitForSeconds(Time);
            GetComponent<Spawner>().SpawnObj(new Vector3(Random.Range(MinX, MaxX), transform.position.y, transform.position.z), Quaternion.identity,Timer);
        }
    }
}
