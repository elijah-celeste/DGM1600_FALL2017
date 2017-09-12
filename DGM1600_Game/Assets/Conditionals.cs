using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour {
	public string stopLight = "Red";

	// Use this for initialization
	void Start () {
		Main();
	}

	void Main(){
	if(stopLight == "Red"){
		print("STOP! The light is Red!");
	}
	else if (stopLight == "Yellow"){
		print("Slow Down!");
	}
	else if (stopLight == "Green"){
		print("Green means GO!");
	}
	else{
		print("I don't know what you mean!");
	}
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
