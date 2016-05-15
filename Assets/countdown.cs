﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countdown : MonoBehaviour {

    float timeLeft = 120;
    Text myText;

	// Use this for initialization
	void Start () {
        myText = GetComponent<Text>();
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if(levelManager.isPlaying == true)
        {
            timeLeft -= Time.deltaTime;
            myText.text = "Time: " + timeLeft.ToString("F2");
            if (timeLeft < 0)
            {
                Time.timeScale = 0;
            }
        }
    }
}
