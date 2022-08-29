using UnityEngine;
using System.Collections;

public class SumasYRestasScript : MonoBehaviour {


	string saludo = "Hola me llamo: ";
	string nombre = "Mariano";

	int a = 11;
	int b = 2;


	void Start()
	{
		Debug.Log (a / b + "Suma");
		Debug.Log (a % b); //resto de una diviaion 11/2: 2 ... 5,5
		Debug.Log (++a); //Incrementa una unidad
		Debug.Log (--a);//Decrementa una unidad
		Debug.Log (saludo + nombre);
		Debug.Log ("Hola " + nombre + " " + "que tal estas");
	}


}
