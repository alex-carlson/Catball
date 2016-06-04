using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class waitingText : MonoBehaviour {

    bool waiting = true;
	
	// Update is called once per frame
	void Update () {

        if (waiting == true)
        {
			if (levelManager.alivePlayers > 1)
            {
                waiting = false;
                StartCoroutine(StartGame());
                return;
            }
        }
	}

    IEnumerator StartGame()
    {
        Text myText = transform.GetComponent<Text>();
        myText.text = "3";
        yield return new WaitForSeconds(1);
        myText.text = "2";
        yield return new WaitForSeconds(1);
        myText.text = "1";
        yield return new WaitForSeconds(1);
        myText.text = "Go!";
        levelManager.isPlaying = true;
        yield return new WaitForSeconds(2);
        myText.text = "";
    }
}
