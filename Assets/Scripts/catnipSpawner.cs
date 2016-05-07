using UnityEngine;
using System.Collections;

public class catnipSpawner : MonoBehaviour {

	public GameObject catnip;
	[Range(1, 50)] public float size = 5;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("dropNip", 2f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void dropNip(){
		size = levelManager.playerCount;
		Instantiate (catnip, new Vector3(Random.value*size, 0, Random.value*size), Quaternion.identity);
	}

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, size);
    }
}
