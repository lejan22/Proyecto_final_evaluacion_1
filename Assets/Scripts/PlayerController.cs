using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 70f;
    public float horizontalInput;
    private float xRange = 200;
    private float yRange = 200;
    public float zRange = 200;
    public GameObject bala;
    public float verticalInput;



    // Start is called before the first frame update
   
    void Start()
    {
        transform.position= new Vector3(0, 100, 0);

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento constante e infinito, en un mundo insondable donde el helicoptero sigue avanzando asiduadamente.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       //Limites del mundo donde cada trabajada vida llega pero no puede continuar, "Finisterra".
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        if (transform.position.y <= -yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        if (transform.position.z >= zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z <= -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
       //Disparar las valientes balas
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(bala, transform.position, transform.rotation);
        }
        //Al presionar las teclas "A, D, IZQ,DER" 
        horizontalInput = Input.GetAxis("Horizontal");
       //Al presionar teclas "S,W,ARRIBA, ABAJO"
        verticalInput = Input.GetAxis("Vertical");
       //Rotara horizontalmente
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);
       //Rotara verticalmente
        transform.Rotate(Vector3.left * speed * Time.deltaTime * verticalInput);
    }

}
