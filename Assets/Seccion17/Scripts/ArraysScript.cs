using UnityEngine;
using System.Collections;

public class ArraysScript : MonoBehaviour {


	string[] letras = new string[5]{"a","b","c","d","e"};
	//                               0   1   2   3   4

	public int[] numeros = new int[6]{0,1,2,3,4,5};


	void Start () {

		Debug.Log(letras[0]);
		Debug.Log(letras[1]);
		Debug.Log(letras[2]);
		Debug.Log(letras[3]);
		Debug.Log(letras[4]);
		letras[0] = "z";
		Debug.Log(letras[0]);

	
	}

}
