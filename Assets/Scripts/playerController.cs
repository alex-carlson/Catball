using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float scale;
	public float speed = 10;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		rb.AddForce(new Vector3(x*speed, 0, y*speed));
	}
}
