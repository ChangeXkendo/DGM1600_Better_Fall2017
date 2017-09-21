using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	public string[] heros = new string [6];

	

	// Use this for initialization
	void Start () {
		heros[0] = "Batman";
		heros[1] = "Superman";
		heros[2] = "Wonder Woman";
		heros[3] = "Green Lantern";
		heros[4] = "Hawkman";
		heros[5] = "Bat Girl";	

		print(heros[3]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
