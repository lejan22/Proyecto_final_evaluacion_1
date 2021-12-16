using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinspawn : MonoBehaviour
{
    private float xrange = 138f;
    private float yrange = 138f;
    private float zrange = 138f;
    private float ydownlimit = 15f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-xrange, xrange);
        float randomY = Random.Range(ydownlimit, yrange);
        float randomZ = Random.Range(-zrange, zrange);
        return new Vector3(randomX, randomY, randomZ);
    }

}
