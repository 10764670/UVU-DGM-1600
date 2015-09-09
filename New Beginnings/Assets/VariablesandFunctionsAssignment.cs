using UnityEngine;
using System.Collections;

public class VariablesandFunctionsAssignment : MonoBehaviour 
{
	int myint = 4;

	void start(){
		myint = Multiplying (myint);
		Debug.Log (myint);
	}

	int Multiplying(int number){
		int ret;

		ret = number * 2;

		return ret;
	}
}
