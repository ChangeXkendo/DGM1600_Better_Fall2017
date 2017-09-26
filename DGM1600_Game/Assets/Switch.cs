using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string townCenter;


	// Use this for initialization
	void Start () {
		switch(townCenter){
			case "main":
				print("Welcome to Main Street!");
			break;	
			case "Balcksmith":
				print("The Blacksmith grumbles as you pick through the sword bin.");
			break;
			case "bakery":
				print("Mmmmmmmm hot buttery buns!");
			break;
			case "morgue":
				print("I guess they took an arrow to the knee one too many time...");
			break;
			default:
				print("I don't know what you are talking about!");
			break;				

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
