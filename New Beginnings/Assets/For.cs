using UnityEngine;
using System.Collections;

public class For : MonoBehaviour {

	int Lemons = 4;
	public float NumA = 4;
	public float NumB = 0;

	void Start () 
	{
		string[] strings = new string[1];

		strings [0] = "1";

		foreach (string item in strings) {
			print (item);
		}

		for (int i = 0; i < Lemons; i++) {
			print ("Printing line#" + i);
			NumB++;
		}
		if (NumB == NumA) 
		{
			print ("Line1");
			print ("Line2");
			print ("Line3");
		}
	}
	
	void Update () {
	
	}

}