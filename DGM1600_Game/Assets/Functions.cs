using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing stuff...");

	}
	void Start(){
		DoStuff();
		int result = AddNumbers(5,11);
		print(result);
		float health = Health(100,50);
		print(health);
		
	}

	public int AddNumbers(int num1,int numb2){
	
		int result = num1 + numb2;

		return result; 
	}	

	public float Health(float currentHealth, float damage){

		float health = currentHealth - damage;

		return health;
	}

	

	}

	
	

