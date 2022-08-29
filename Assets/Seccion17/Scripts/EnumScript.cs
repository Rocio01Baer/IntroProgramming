using UnityEngine;
using System.Collections;
using System;

public class EnumScript : MonoBehaviour {

	public enum Brujula { none, Norte, Sur, Este, Oeste };
	public Brujula miDrección;

	void Start() 
	{
		miDrección = Brujula.Norte;
	}

	void Update()
	{
		DireccionOpuestaCondicional (miDrección);
	}
		
	Brujula DireccionOpuestaCondicional (Brujula dir)
	{
		if(dir == Brujula.Norte)
		{
			dir = Brujula.Sur;
			Debug.Log(dir);
		}
		else if(dir == Brujula.Sur)
		{
			dir = Brujula.Norte;
			Debug.Log(dir);
		}
		else if(dir == Brujula.Este)
		{
			dir = Brujula.Oeste;
			Debug.Log(dir);
		}
			
		else if(dir == Brujula.Oeste)
		{
			dir = Brujula.Este;
			Debug.Log(dir);
		}
		return dir;     
	}
}
