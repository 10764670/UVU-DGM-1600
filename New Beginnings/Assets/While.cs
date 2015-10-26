using UnityEngine;
using System.Collections;

public class While : MonoBehaviour 
{

	int Lemons = 1;

	void Start () 
	{
		while (Lemons > 0) {
			print ("Line1");
			Lemons--;
		}

		do {
			print ("Line2");
			Lemons--;
		} while (Lemons == 0);
	}

	void Update () {
	
	}
}