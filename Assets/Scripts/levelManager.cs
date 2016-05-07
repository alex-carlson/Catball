using UnityEngine;
using System.Collections;

public class levelManager : MonoBehaviour {

	public static int playerCount;
	GameObject levelGeometry;

	// Use this for initialization
	void Start () {
		//debug player count
		playerCount = 35;

		levelGeometry = GameObject.Find ("Level");
        StartCoroutine("levelGen");
	}

	IEnumerator levelGen(){
        Vector3 newScale = Vector3.one * (playerCount / 4);
        levelGeometry.transform.localScale = Vector3.Lerp(levelGeometry.transform.localScale, newScale, 0.1f);
        Camera.main.GetComponent<CameraBehaviour>().SetCameraDistance();
		yield return new WaitForSeconds (1);
	}
}
