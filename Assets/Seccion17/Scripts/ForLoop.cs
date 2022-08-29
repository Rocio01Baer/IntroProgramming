using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	public int[] numeros2 = new int[6]{15,20,56,67,42,5};
	int incremento = 0;

	void Start () 
	{
		Debug.Log(incremento + " esto es incremento antes del loop");

		for (int i = 0; i < numeros2.Length; i ++)
		{
			Debug.Log(numeros2[i]);

			incremento ++;
		}

		Debug.Log(incremento + " esto es incremento despues del loop");
	}
}