﻿using UnityEngine;
using System.Collections;

public class endGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void gameOver()
    {
        Animator anim = GameObject.Find("Game Over Text").GetComponent<Animator>();
        anim.SetBool("isAlive", true);
    }
}
