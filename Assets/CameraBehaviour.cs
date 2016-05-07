using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetCameraDistance()
    {
        GetComponent<Camera>().orthographicSize = 24 + (levelManager.playerCount / 4);
    }
}
