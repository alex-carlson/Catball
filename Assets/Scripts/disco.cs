using UnityEngine;
using System.Collections;

public class disco : MonoBehaviour {

	Light myLight;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
		InvokeRepeating ("changeColor", 1, 1);
	}

    void changeColor()
    {
        Color myColor = Random.ColorHSV(0, 1, 1, 1, 1, 1);
        myLight.color = Color.Lerp(myLight.color, myColor, 0.1f);
    }
}
