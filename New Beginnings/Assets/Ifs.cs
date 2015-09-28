using UnityEngine;
using System.Collections;

public class Ifs : MonoBehaviour 
{

	public float LemonsEnough = 5;
	public float LemonsTooMany = 20;
	public float Lemons = 0;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			LemonsTest();
			Lemons = Lemons + 1;
		}
	}

	void LemonsTest ()
	{
		if (Lemons == LemonsEnough) 
		{
			Debug.Log ("When life gives you lemons, make lemonade.");
		} else if (Lemons == LemonsTooMany) 
		{
			Debug.Log ("On second thought...");
		} else 
		{
			Debug.Log ("Added a lemon");
		}
	}
}
