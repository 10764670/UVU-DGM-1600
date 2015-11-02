using UnityEngine;
using System.Collections;

public class ScopesAccess : MonoBehaviour 
{
	public int Alfa = 0;

	private int Bravo = 0;
	private int Charlie = 5;

	public Rigidbody rb;
	public Rigidbody rb2;
	void Gravity () 
	{
		Physics.gravity = new Vector3 (0, 1.0F, 0);
	}

	void Update () {
		if (Input.GetKeyDown ("space")) {
			if (Bravo < Charlie) {
				GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
				sphere.AddComponent<Rigidbody> ();
				rb = sphere.GetComponent<Rigidbody> ();
				sphere.transform.position = new Vector3 (0, 1, 0);
				rb.velocity = new Vector3 (4, 0, 0);
				Bravo++;
			}
		}
		if (Bravo == Charlie && Alfa == 0) {
			Alfa++;
			print ("I am all out of spheres. Do you want a cube to play with? (press y/n)");
		
		}
		if (Input.GetKeyDown ("y")) {
			if (Alfa == 1) {
				GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube.AddComponent<Rigidbody> ();
				rb2 = cube.GetComponent<Rigidbody> ();
				cube.transform.position = new Vector3 (0, 2, 0);
				Alfa++;
			}
			else if (Alfa != 1) {
				print ("You broke it. Good going. Let me fix it for you");
				Alfa = 1;
			}
		}
		if (Input.GetKeyDown ("n")) {
			if (Alfa == 1) {
				print ("Alright.");
			}
		}
	}
}
