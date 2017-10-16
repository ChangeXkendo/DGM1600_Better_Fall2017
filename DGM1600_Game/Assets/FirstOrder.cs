using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FirstOrder :IComparable<FirstOrder> {
	public string name;
	public int power;

	public FirstOrder(string newName, int newPower){
		name = newName;

		power = newPower;
	}

	public int CompareTo(FirstOrder other){
		if(other == null){
			return 1;
		}

		return power - other.power;
	}
	// Use this for initialization

}
public class Champion :IComparable<FirstOrder> {
	public string name;
	public int power;

	public Champion(string newName, int newPower){
		name = newName;

		power = newPower;

	}
	public int CompareTo(Champion other){
		if(other == null){
			return 1;
		}
		return power - other.power;
	}




}