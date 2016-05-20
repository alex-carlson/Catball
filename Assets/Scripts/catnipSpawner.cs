using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class catnipSpawner : MonoBehaviour {

	public GameObject catnip;
    List<Vector3> nipPoints = new List<Vector3>();
    [Range(1, 50)] public float size = 5;

    // Use this for initialization
    void Start () {
        GameObject[] spawnCount = GameObject.FindGameObjectsWithTag("NipSpawner");

        for(int i = 0; i < spawnCount.Length; i++)
        {
            nipPoints.Add(spawnCount[i].transform.position);
        }
		InvokeRepeating ("dropNip", 2f, 5f);
	}

	public void dropNip(){
        //int r = Mathf.RoundToInt(Random.Range(0, nipPoints.Count));
        //Instantiate (catnip, nipPoints[r], Quaternion.identity);

        size = levelManager.playerCount;
        Instantiate(catnip, new Vector3(Random.value * size, 0, Random.value * size), Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, size);
    }
		
}
