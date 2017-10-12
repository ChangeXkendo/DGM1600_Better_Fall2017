﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachList : MonoBehaviour {

		
	// Use this for initialization
	void Start () {
		List<FirstOrder> badguys = new List<FirstOrder>();

		badguys.Add( new FirstOrder("Snoke",1000));
		badguys.Add( new FirstOrder("General Hux",20));
		badguys.Add( new FirstOrder("Kylo Ren",400));
		badguys.Add( new FirstOrder("Captain Phasma",150));
	
		badguys.Sort();

		foreach(FirstOrder guy in badguys){
			print(guy.name +"  "+ guy.power);
		}
		




		List<Champion> heros = new List<Champion>();

		heros.Add( new Champion("Albon", 6000));
		heros.Add( new Champion("Fay",1000));
		heros.Add( new Champion("Alei",500));
		

	
	}

	
	// Update is called once per frame
	
}
