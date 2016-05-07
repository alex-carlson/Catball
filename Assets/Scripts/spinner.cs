using UnityEngine;
using System.Collections;

public class spinner : MonoBehaviour {

	public int rotateSpeed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * rotateSpeed);
	}
}
