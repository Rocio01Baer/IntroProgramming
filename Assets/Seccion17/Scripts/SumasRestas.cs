using UnityEngine;
using System.Collections;

public class SumasRestas : MonoBehaviour {

	string nombre = "Mariano";
	string saludo = "Hola que tal";

	int a = 11;
	int b = 2;

	void Start () {
		Debug.Log (a + b + " esto es una suma");
		Debug.Log (a - b + " esto es una resta");
		Debug.Log (a / b + " esto es una división");
		Debug.Log (a * b + " esto es una multiplicación");
		Debug.Log (a % b + " esto es una resto");
		Debug.Log (++a);
		Debug.Log (--b);

		Debug.Log (saludo + " " + nombre);
	
	}
	

}
