using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Player : MonoBehaviour
{
    public float speed = 10f;
    public Transform target;
    
   

    // Update is called once per frame
    void Update()
    {
        //El perro con pocos amigos te perseguir� sin cesar con esta l�nea
        //As� apunta hacia t�
        transform.LookAt(target);
        //Avanza sin parar
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
