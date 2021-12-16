using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject coin;
    public GameObject obstaculo;
    public Vector3 spawnPos;
    private float xrange = 138f;
    private float yrange = 138f;
    private float zrange = 138f;
    private float ydownlimit = 15f;
    // Start is called before the first frame update
    void Start()
    {
        //Aparecen los inocentes perritos
        InvokeRepeating("SpawnPerro", 2, 5f);

         

    }




    public Vector3 RandomSpawnPos()
    {
        //Creación en un lugar aleatorio por la gracia de Dios de los perritos en avioneta
        float randomX = Random.Range(-xrange, xrange);
        float randomY = Random.Range(ydownlimit, yrange);
        float randomZ = Random.Range(-zrange, zrange);
        return new Vector3(randomX, randomY, randomZ);
    }
    public void SpawnPerro()
    {
        spawnPos = RandomSpawnPos();
        Instantiate(obstaculo, spawnPos, obstaculo.transform.rotation);

    }
}
