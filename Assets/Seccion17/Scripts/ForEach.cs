using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	string[] animales = { "perro", "gato", "elefante"};

	void Start () 
	{
		foreach (string animal in animales)
		{
			Debug.Log(animal);
		}
	}

}
