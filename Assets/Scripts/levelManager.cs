﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class levelManager : MonoBehaviour {

	public static int playerCount;
    public static bool isPlaying = false;
    public GameObject block;
    GameObject levelGeometry;
    public enum Stage { hill, blockFort };
    public Stage stage;
	public static bool[] playersShaking;

    // Use this for initialization
    void Start () {

		playerCount = 2;
        

		levelGeometry = GameObject.Find ("Level");

        if (stage == Stage.hill)
        {
            StartCoroutine("HillGen");
        } else if (stage == Stage.blockFort)
        {
            StartCoroutine("BlockFort");
        }
	}

//	void Update(){
//		for(int i = 0;  i< playersShaking.Length; i++){
//			if(playersShaking[i] == false){
//				return;
//			}
//			GameObject.Find ("Catnip Spawner").GetComponent<catnipSpawner> ().dropNip ();
//		}
//	}

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
}
