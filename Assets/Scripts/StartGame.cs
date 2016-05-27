using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public GameObject mainMenuItems;


    public void LoadLevel()
    {
		
		SceneManager.LoadSceneAsync ("Hill", LoadSceneMode.Additive);
		fadeOut ();
    }

	public void fadeOut(){
		mainMenuItems.SetActive (false);
		//this.gameObject.SetActive (false);
	}
}
