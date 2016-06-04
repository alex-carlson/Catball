using UnityEngine;
using System.Collections;
using HappyFunTimes;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {

	public static int playerCount = 0;
    public static bool isPlaying = false;
    public GameObject block;
    GameObject levelGeometry;
    public enum Stage { hill, blockFort };
    public Stage stage;
	public static bool[] playersShaking;
	public static int alivePlayers = 0;

    // Use this for initialization
    void Start () {

//		playerCount = 0;
//		alivePlayers = playerCount;

		levelGeometry = GameObject.Find ("Level");

//        if (stage == Stage.hill)
//        {
//            StartCoroutine("HillGen");
//        } else if (stage == Stage.blockFort)
//        {
//            StartCoroutine("BlockFort");
//        }
	}

	void Update(){
//		for(int i = 0;  i< playersShaking.Length; i++){
//			if(playersShaking[i] == false){
//				return;
//			}
//			GameObject.Find ("Catnip Spawner").GetComponent<catnipSpawner> ().dropNip ();
//		}

		if (Input.GetKeyDown (KeyCode.K)) {
			alivePlayers--;
			Debug.Log ("Alive Players: " + alivePlayers);
		}

		if (Input.GetKeyDown (KeyCode.L)) {
			alivePlayers++;
			Debug.Log ("Alive Players: " + alivePlayers);
		}

		if (alivePlayers == 1 && isPlaying == true) {
			StartCoroutine (startGame (0, 1, 1));
		}
	}

	IEnumerator HillGen(){
        Vector3 newScale = Vector3.one * (playerCount / 4);
        levelGeometry.transform.localScale = Vector3.Lerp(levelGeometry.transform.localScale, newScale, 0.1f);
        Camera.main.GetComponent<CameraBehaviour>().SetCameraDistance();
		yield return new WaitForSeconds (1);
	}

    IEnumerator BlockFort()
    {
        int blockCountSquared = playerCount / 4;

        for(int i = 0; i < blockCountSquared; i++)
        {
            //top row

            Instantiate(block, new Vector3(0, 3.5f, 0), Quaternion.identity);

            //left row

            // bottom row

            // right row
        }

        Instantiate(block, transform.position, Quaternion.identity);
        Camera.main.GetComponent<CameraBehaviour>().SetCameraDistance();
        yield return new WaitForSeconds(1);
    }
	public IEnumerator startGame(float alphaStart, float alphaFinish, float time){
		float elapsedTime = 0;

		this.enabled = false;

		Camera.main.GetComponent<SimpleBlit> ().TransitionMaterial.SetFloat ("_Cutoff", alphaStart);

		while (elapsedTime < time) {
			Camera.main.GetComponent<SimpleBlit> ().TransitionMaterial.SetFloat ("_Cutoff", elapsedTime);
			elapsedTime += Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		SceneManager.LoadScene ("GameOver", LoadSceneMode.Additive);
	}
}
