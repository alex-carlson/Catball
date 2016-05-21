﻿using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 15);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Catball") {
            col.transform.GetComponent<playerController>().scale += 0.25f;
			GetComponent<AudioSource> ().Play ();
			GetComponent<MeshRenderer> ().enabled = false;
			GetComponent<BoxCollider> ().enabled = false;
            Destroy(this.gameObject, 1f);
        }
    }
}
