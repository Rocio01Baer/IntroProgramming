using UnityEngine;
using System.Collections;

public class Funciones : MonoBehaviour {


	void Start () 
	{  
		Saludo();
		// Funcion Nombre;
	}
	
	void Saludo()
	{
		Debug.Log("Hola");
		Nombre();
	}

	void Nombre()
	{
		Debug.Log("Mariano");
		Debug.Log("Rivas");
	}


}
