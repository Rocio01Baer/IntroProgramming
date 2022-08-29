using UnityEngine;
using System.Collections;

public class Enumerados : MonoBehaviour {

	public enum Brujula {none, Norte,Sur,Este,Oeste};

	Brujula miDireccion = Brujula.Norte;


	void Start () {

		Debug.Log("Mi direccion actual es :" + miDireccion);
		RevertirDireccion(miDireccion);
		Debug.Log("Mi direccion revertida es :" + miDireccion);

	}
	

	void Update () {

		Debug.Log(miDireccion);
	
	}


	Brujula RevertirDireccion(Brujula dir)
	{
		if (dir == Brujula.Norte)
		{
			miDireccion = Brujula.Sur;
		}
		return dir;
	}
}
