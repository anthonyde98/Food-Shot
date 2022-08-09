using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float desplazamientoHorizontal;
    public float velocidad = 10.0f;
    public float rangoX = 20.0f;
    public GameObject[] proyectilComida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -rangoX)
        {
            transform.position = new Vector3(-rangoX, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > rangoX)
        {
            transform.position = new Vector3(rangoX, transform.position.y, transform.position.z);
        }

        desplazamientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * desplazamientoHorizontal * velocidad);
    }
}
