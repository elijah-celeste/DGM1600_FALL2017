using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello_World : MonoBehaviour {

	string message = "Help Me!";
	float testNumber = 1;

	// Use this for initialization
	void Start () {
		print("Hello World");
		print(message);
		print("Hello World " + testNumber + 12 + " " + message);
	}
	
	// Update is called once per frame
	void Update () {
		print(testNumber+=1);
	}
}
