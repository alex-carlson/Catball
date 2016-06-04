using UnityEngine;
using System.Collections;

public class spinner : MonoBehaviour {

	public int x = 2;
	public int y = 2;
	public int z = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (x, y, z);
	}
}
