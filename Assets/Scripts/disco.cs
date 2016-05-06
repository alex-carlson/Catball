using UnityEngine;
using System.Collections;

public class disco : MonoBehaviour {

	Light myLight;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
		InvokeRepeating ("changeColor", 1, 1);
	}

	void changeColor(){
		myLight.color = Random.ColorHSV (0, 1, 1, 1, 1, 1);
	}
}
