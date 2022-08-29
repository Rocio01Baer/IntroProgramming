using UnityEngine;
using System.Collections;

public class CondicionealesScript : MonoBehaviour {

	public int velocidadCoche;
	int velocidadMaxima = 120;

	// Update is called once per frame
	void Update ()
	{
		if(velocidadCoche>velocidadMaxima)
		{
			Debug.Log("Has pasado el limite de velocidad");
		}
		else
		{
			Debug.Log("Vas a una velocidad normal");
		}
	}
}
