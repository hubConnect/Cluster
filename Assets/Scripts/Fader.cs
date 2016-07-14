using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {

	void Update()
	{
		Color temp = GetComponent<Renderer>().material.color;
		temp.a -= 0.02f;
		GetComponent<Renderer>().material.color = temp;
	}
}
