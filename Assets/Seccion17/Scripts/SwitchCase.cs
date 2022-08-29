using UnityEngine;
using System.Collections;

public class SwitchCase : MonoBehaviour {

	public int vidas = 1;

	void Start ()
	{
		switch (vidas)
		{
			case 0:

				Debug.Log(vidas + " caso 0");
				break;

			case 1:
				Debug.Log(vidas + " caso 1");
				break;

			case 2:
				Debug.Log(vidas + " caso 2");
				break;

			default:
				Debug.Log(vidas + " caso default");
				break;

		}
	}
	

}
