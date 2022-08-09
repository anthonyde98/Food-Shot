using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        Destroy(gameObject);

        if(gameObject.name != "Food_Steak_01(Clone)")
        {
            if (gameObject.name != "Food_Pizza_01(Clone)")
            {
                GameManager.puntos++;
            }
        }
    }
}
