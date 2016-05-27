using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public GameObject mainMenuItems;


    public void LoadLevel()
    {
		if (mainMenuItems == null) {
			SceneManager.LoadScene ("Main Menu");
		} else {
			fadeOut ();
			SceneManager.LoadScene ("Hill", LoadSceneMode.Additive);
		}
    }

	public void fadeOut(){
		mainMenuItems.SetActive (false);
		//this.gameObject.SetActive (false);
	}
}
