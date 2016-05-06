using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {

	public static int playerCount;
	GameObject levelGeometry;

	// Use this for initialization
	void Start () {
		levelGeometry = GameObject.Find ("Level");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator levelGen(){
		
		yield return new WaitForSeconds (1);
	}
}
