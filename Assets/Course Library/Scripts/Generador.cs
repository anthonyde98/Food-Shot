using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject jugador;
    public GameObject[] proyectilComida;
    public GameObject[] animales;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("generarAnimales", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        generarProyectil();
    }

    void generarAnimales()
    {
        int indexAnimal = Random.Range(0, animales.Length);
        int positionAnimal = Random.Range(-20, 20);

        Instantiate(animales[indexAnimal], new Vector3(positionAnimal, 0, 20), animales[indexAnimal].transform.rotation);
    }

    void generarProyectil()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilComida[0], jugador.transform.position, jugador.transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(proyectilComida[1], jugador.transform.position, jugador.transform.rotation);
        }
    }
}
