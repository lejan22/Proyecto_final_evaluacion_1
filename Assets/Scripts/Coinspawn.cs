using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinspawn : MonoBehaviour
{
    private float xrange = 138f;
    private float yrange = 138f;
    private float zrange = 138f;
    private float ydownlimit = 15f;
    private float randomX;
    private float randomY;
    private float randomZ;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomSpawnPos();
    }

    
   
    public Vector3 RandomSpawnPos()
    {
        //Colocar las monedas en un lugar aleatorio.
         randomX = Random.Range(-xrange, xrange);
         randomY = Random.Range(ydownlimit, yrange);
         randomZ = Random.Range(-zrange, zrange);
        return new Vector3(randomX, randomY, randomZ);
    }

}
