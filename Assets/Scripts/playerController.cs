using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	[HideInInspector] public float scale;
    float shrinkSpeed = 7000;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		scale = transform.localScale.x;
		levelManager.playerCount++;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (levelManager.isPlaying == false) {
			return;
		} else {
			if (GetComponent<Rigidbody> ().useGravity == false) {
				GetComponent<Rigidbody> ().useGravity = true;
			}
		}

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
		levelManager.alivePlayers--;
		this.gameObject.SetActive (false);
		Debug.Log ("Died.  There are "+levelManager.alivePlayers+" Cats left");
    }
}
