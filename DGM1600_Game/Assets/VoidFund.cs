using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFund : MonoBehaviour {
	public int laserBlast;
	// Use this for initialization
	void Start () {
		DeathStar(laserBlast);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent){
		print ("That's no moon that is a space station!");
		

		if(vent == 1){
			print("Porkin's sucks!");
		}

		else if(vent == 2){
			print("Red Leader missed!");

		}
		else{
			print("Use the Force, Luke!");
		
		}
		
	}
}
