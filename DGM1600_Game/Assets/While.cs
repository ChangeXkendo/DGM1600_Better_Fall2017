using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {


	public int bottles = 0;
	public int money = 0;
	public int fuel = 0;
	public int power = 200;
	public float time = 100;


	// Use this for initialization
	void Start () {
		// while(bottles < 100){
		// 	bottles ++;
		// 	print(bottles + " bottles of beer on the wall!");
			
		// }
		// while(money > 100){
		// 	money --;
		// 	print(money + "Coins!");
		// }
		// while(fuel < 100){
		// 	fuel --;
		// 	print(fuel + "Gas left!");
		// }
		// while(power < 200){
		// 	power --;
		// 	print("Your Magic is low!");
		// }
		while(time > 0){
			time ++;
			print("the time is" + time);
		}

	
	
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
