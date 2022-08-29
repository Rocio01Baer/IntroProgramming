using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	int[] incrementoDeSuma = new int[] { 6, 6, 6, 6 };
	int resultado = 0;
	int i = 0;

	void Start () 
	{
		do
		{
			resultado += incrementoDeSuma[i];
			Debug.Log(resultado + "incremento de suma ");

			i++;
			Debug.Log(i + " valor de i");

		} 
		while (i < 4);
		Debug.Log(resultado + "Resultado fuera del bucle");
	}
}
