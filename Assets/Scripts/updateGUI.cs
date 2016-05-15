using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class updateGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        SetPlayerCount();
	}

    public void SetPlayerCount()
    {
        GetComponent<Text>().text = "Players: " + levelManager.playerCount;
    }
}
