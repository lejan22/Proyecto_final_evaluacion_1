using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outofbounds : MonoBehaviour
{
    private float OutOfBounds= 500f;
    

    // Update is called once per frame
    void Update()
    {
        //Limites del mundo donde todo ser desa llegar, pero su deseo es inconcedible 
        if (transform.position.z > OutOfBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -OutOfBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > OutOfBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -OutOfBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > OutOfBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -OutOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
