using UnityEngine;
using System.Collections;

public class disco : MonoBehaviour {

	Light myLight;
	private Color myColor;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
		InvokeRepeating ("changeColor", 1, 2);
	}

	void Update(){
		myLight.color = Color.Lerp(myLight.color, myColor, Time.deltaTime);
	}

    void changeColor()
    {
        myColor = Random.ColorHSV(0, 1, 1, 1, 1, 1);
    }
}
