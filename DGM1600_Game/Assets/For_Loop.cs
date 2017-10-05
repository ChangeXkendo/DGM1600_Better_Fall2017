using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loop : MonoBehaviour {
	public int bottles = 100;
	// Use this for initialization
	void Start () {

		// while(bottles > 0){
		// 	print(bottles+" of orange crush on the wall");
		// 	bottles --;
		for(; bottles > 0; bottles --){
				
			print(bottles+" of orange crush on the wall");

		}
		}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
