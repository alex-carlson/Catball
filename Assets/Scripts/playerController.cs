using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	[HideInInspector] public float scale;
	public float speed = 10;
    float shrinkSpeed = 7000;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		scale = transform.localScale.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

        rb.AddForce(new Vector3(x * speed, 0, y * speed), ForceMode.Force);

        scale -= Time.deltaTime/shrinkSpeed;

        Vector3 newScale = Vector3.one * scale;

        if(newScale.x > 0)
        {
            transform.localScale = newScale;
        } else
        {
            Die();
        }
	}

	void Update(){
		if (transform.position.y < -10) {
			Die ();
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Catball") {
			GetComponent<AudioSource> ().Play ();
		}
	}

    void Die()
    {
		
    }
}
