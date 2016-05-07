using UnityEngine;
using System.Collections;

public class catnipSpawner : MonoBehaviour {

	public GameObject catnip;
	[Range(1, 50)] public int size = 10;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("dropNip", 2f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void dropNip(){
		size = size + levelManager.playerCount;
		Instantiate (catnip, new Vector3(Random.value*size, 0, Random.value*size), Quaternion.identity);
	}
}
