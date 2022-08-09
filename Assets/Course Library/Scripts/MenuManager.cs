using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public int puntos = 0;
    public Text punText;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Puntos"))
            punText.text = "Puntos: " + PlayerPrefs.GetInt("Puntos").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Juego()
    {
        //Cargo la escena de inicio
        SceneManager.LoadScene("Prototype 2");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
