using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {

	public static int playerCount;
	GameObject levelGeometry;

	// Use this for initialization
	void Start () {
		//debug player count
		playerCount = 4;
		levelGeometry = GameObject.Find ("Level");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator levelGen(){
		levelGeometry.transform.localScale = Vector3.one * (playerCount/4);
		yield return new WaitForSeconds (1);
	}
}
