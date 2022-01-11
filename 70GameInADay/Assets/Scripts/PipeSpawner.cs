using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float Min, Max;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObj());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObj()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            float Rand = Random.Range(Min, Max);
            GameObject O = Instantiate(Pipe, new Vector3(7, Rand, -2.818883f), Quaternion.identity) as GameObject;
            Destroy(O, 30);
        }
    }
}
