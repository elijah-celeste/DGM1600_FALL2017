using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {

	public float valueOne;

	public float valueTwo;

	public float valueThree;

	public float valueFour;

	private float result;

	// Use this for initialization
	void Start () {
		DoMath();
	}

	void DoMath () {
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo  + " = " + result);

		result = valueOne - valueTwo;
		print(valueOne + " - " + valueTwo + " = " + result);

		result = valueOne * valueTwo;
		print(valueOne + " * " + valueTwo + " = " + result);

		result = valueOne / valueTwo;
		print(valueOne + " / " + valueTwo + " = " + result);

		result = valueOne + valueThree - valueFour;
		print(valueOne + " + " + valueThree + " - " + valueFour + " = " + result);

		result = valueTwo / valueOne * valueThree;
		print(valueTwo + " / " + valueOne + " * " + valueThree + " = " + result);

		result = valueThree * valueOne + valueTwo;
		print(valueThree + " * " + valueOne + " + " + valueTwo + " = " + result);

		result = valueFour * valueOne / (valueThree + valueTwo);
		print(valueFour + " * " + valueOne + " / " + "(" + valueThree + " + " + valueTwo + ")" + " = " + result);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}	
