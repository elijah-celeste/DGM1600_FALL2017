using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heroes = new string[6];


	// Use this for initialization
	void Start () {
		heroes[0] = "Pharah";
		heroes[1] = "Zenyatta";
		heroes[2] = "Mei";
		heroes[3] = "Winston";
		heroes[4] = "D.Va";
		heroes[5] = "Bastion";
		
		print(heroes[5]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
