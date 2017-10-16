//A while loop is a loop that allows you to add or subtract a funcion as long it is within the perameters that you have set.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {


	public int bottles = 0;
	public int money = 0;
	public int fuel = 0;
	public int power = 200;
	public float time = 100;
	public int health = 100;
	public float space = 100;
	public int stamina = 250;
	public int rations = 100;
	public int ammo = 0;


	// Use this for initialization
	void Start () {
		while(bottles < 100){
			bottles ++;
			print(bottles + " bottles of beer on the wall!");
			
		}
		while(money > 100){
			money --;
			print(money + "Coins!");
		}
		while(fuel < 100){
			fuel --;
			print(fuel + "Gas left!");
		}
		while(power < 200){
			power --;
			print("Your Magic is low!");
		}
		while(time > 0){
			time ++;
			print("the time is" + time + "O'clock.");		
		}
		while(health < 100){
			halth --;
			print(health + "Health left; you're still alive");
		}
		while(space < 100){
			space --;
			print(space + "It is only going to get lower from here.");
		}
		while(stamina > 0){
			stamina --;
			print(stamina + "You're getting tired.");
		}
		while(rations > 0){
			rations --;
			print(rations + "You better watch what you eat.");
		}
		while(ammo < 400){
			ammo ++;
			print(ammo + "ammo");
		}
	
	
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
