using UnityEngine;
using System.Collections;

public class Condicionales : MonoBehaviour {

	public int velocidadCoche;
	private int velocidadMaxima = 120; 
	private int velocidadMinima = 40;

	void Update () {

		if ( velocidadCoche > velocidadMaxima ) 
		{
			Debug.Log("Has superado la velocidad maxima");
		}
		else if( velocidadCoche < velocidadMinima )
		{
			Debug.Log("Estas en la velocidad minima");
		}
		else
		{
			Debug.Log("Estas entre la velocidad minima y maxima");
		}

		/*
		 * A > B
		 * A < B
		 * A >= B
		 * A <= B
		 * A == B
		 * A != B
		 *    
		 *   A > B & A < B  (y)
		 *   A > B // A < B (o)
		 * 
		 * 
		 * 
		 * 
		 * /
		*/
	
	}
}
