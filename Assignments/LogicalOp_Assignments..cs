using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Logical Operators are symbols that are used in coding to do simple math actions such as adding, subtracting, etc..
//These operations usually come as ==, !=, <, >, &, |.


public class LogicalOp : MonoBehaviour {
	public string luke = "Jedi";

	public string vader = "Sith";
	
	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi-Wan";

	public string fruit = "Banana";
	
	public string vegitable = "Tomato";

	public int gold = 100;



	// Use this for initialization
	void Start () {
		 if(luke == "Jedi" && vader == "Nanny" ){

		 	print("Vaders yo Nanny!");
		 }
		 else if (luke == "Jawa" && vader == "Sith"){

		 	print("Utini!");
		 }
		 else if (luke == "Jedi" && vader == "Sith"){

		 	print("Noooooo! Tha's not true.... That's impossible!");

		 }
		 else{
		 	print("The End!");
		 }
	
		 if(leia){
		 	print("No, there is another!");
		 }
		 else if(!leia){
		 	print("Hurray! Now I can date luke");

		 }
		 else{
		 	print("Han fired first!");
		 }

			 if(lightSide == "Obi-Wan" || darkSide == "Jar Jar Binks"){
			 	print("Meeeza Evil Bad Bad Sith Lordie");

			 }
			 else if(lightSide == "Bobba Fett" || darkSide == "Darth Mual"){
			 	print("As you wish, my master.");
			 }
			
			 else{
			 	print("Not the younglings!");
			 }

			 if(fruit == "Banana" && vegitable == "Tomato"){
			 	print ("The world is in order");
			 }
			 else if(fruit == "Banana" && vegitable == "Apple"){
			 	print("Are you Insane!?");
			 }
			 else{
			 	print("Am I on earth anymore?");
			 } 

		if(gold == 100){
			print("Jackpot!");
		}
		else if(gold != 100){
			print("Nope, Try again.");
		}	
		
		else{
			print("You Lose... NO Gold!");
		}

			

	 }
	// Update is called once per frame
	void Update () {
		
	}
}
