using UnityEngine;
using System.Collections;

public class FuncionesConDatos : MonoBehaviour {


	int edad =33;
	string s;

	void Start () 
	{  
		Saludo();
	}
	
	void Saludo()
	{
		Debug.Log("Hola");
		Nombre();
		DecirEdad(edad);
		Debug.Log(DimeEdad());
	}

	void Nombre()
	{
		Debug.Log("Mariano");
		Debug.Log("Rivas");
	}

	void DecirEdad(int e)
	{
		Debug.Log(e);
	}

	int DimeEdad()
	{
		return edad;
	}

	string SoyUnString()
	{
		s =  "Hola";
		return s;
	}


}
