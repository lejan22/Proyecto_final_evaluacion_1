using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_forward : MonoBehaviour
{
    public float speed = 200f;
    
  

    // Update is called once per frame
    void Update()
    {
        //La valiente bala avanza sin cesar, hacia su destino donde encontrará su deseada misión
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
