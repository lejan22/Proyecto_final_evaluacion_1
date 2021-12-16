using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helices_perro : MonoBehaviour
{
    public float speed = 1000f;
   

    // Update is called once per frame
    void Update()
    {
        //Helices del perro hacen zip zoom
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
