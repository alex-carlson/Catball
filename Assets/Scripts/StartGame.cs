using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public GameObject mainMenuItems;

	void Update(){
		if (Input.anyKeyDown) {
			StartCoroutine (startGame (0, 1, 1));
		}
	}


    public void LoadLevel()
    {
		if (mainMenuItems == null) {
			startGame (0f, 1f, 4f);
		} else {
			fadeOut ();
			SceneManager.LoadScene ("Hill", LoadSceneMode.Additive);
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
		SceneManager.LoadScene ("Hill");
	}
}
