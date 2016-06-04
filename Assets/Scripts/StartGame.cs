using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public GameObject mainMenuItems;
	public bool mainMenu = true;

	void Update(){
		if (Input.anyKeyDown) {

			if (mainMenu) {
				StartCoroutine (startGame (0, 1, 1));
			} else {
				StartCoroutine (startGame (1, 0, 1));
			}
		}
	}

	public void fadeOut(){
		mainMenuItems.SetActive (false);

		//this.gameObject.SetActive (false);
	}

	public IEnumerator startGame(float alphaStart, float alphaFinish, float time){
		float elapsedTime = 0;

		Camera.main.GetComponent<SimpleBlit> ().TransitionMaterial.SetFloat ("_Cutoff", alphaStart);

		while (elapsedTime < time) {
			Camera.main.GetComponent<SimpleBlit> ().TransitionMaterial.SetFloat ("_Cutoff", elapsedTime);
			elapsedTime += Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}

		if (mainMenu) {
			fadeOut ();
			SceneManager.LoadScene ("Hill", LoadSceneMode.Additive);
		} else {
			SceneManager.LoadScene ("Main Menu");
			levelManager.isPlaying = false;
		}
	}
}
