using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 70f;
    public float horizontalInput;
    public float xRange = 200;
    public float yRange = 200;
    public float zRange = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(yRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(yRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(zRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > -zRange)
        {
            transform.position = new Vector3(yRange, transform.position.y, transform.position.z);
        }
    }

}
