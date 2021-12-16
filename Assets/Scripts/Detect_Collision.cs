using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision otherCollider)
    {
       //Destruir obstaculo con la bala
        if (gameObject.CompareTag("Obstacle") && otherCollider.gameObject.CompareTag("Proyectile"))
        {
            //Destruir el animal contra el que colisiono
            Destroy(otherCollider.gameObject);
            //Destruir proyectil
            Destroy(gameObject);
        }
       //Mensaje de Game Over , el tiempo se para
        if (gameObject.CompareTag("Obstacle") && otherCollider.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Debug.Log("Te acaba de matar un perro en una avioneta... Patetico");
        }

    }
    
    
}
