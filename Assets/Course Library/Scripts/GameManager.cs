using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static int puntos = 0;
	public Text canText;
	public Text pausa;

	void Start()
	{

	}

	void Update()
    {
		canText.text = puntos.ToString();

		if(Input.GetKeyDown(KeyCode.Escape)) 
        {
			GuardarPuntos();
			puntos = 0;
			SceneManager.LoadScene("Menu Inicio");
		}
		else if(Input.GetKeyDown(KeyCode.P))
        {
			GuardarPuntos();

			if(Time.timeScale == 1)
			{
				pausa.text = "-> En Pausa. <-";
				Time.timeScale = 0;
			}
			else if(Time.timeScale == 0)
			{
				pausa.text = "";
				Time.timeScale = 1;
			}
		}

    }

	public static void GuardarPuntos()
    {
        if (PlayerPrefs.HasKey("Puntos"))
        {
			if(PlayerPrefs.GetInt("Puntos") < puntos)
            {
				PlayerPrefs.SetInt("Puntos", puntos);
			}
		}
        else
        {
			PlayerPrefs.SetInt("Puntos", puntos);
		}
	}

}