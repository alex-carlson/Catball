using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour {

	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	Transform camTransform;


	Vector3 offset = Vector3.zero;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float speed = 5000f;

	private float fraction = 0; 

	Vector3 originalPos;

	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void Start()
	{
		originalPos = camTransform.localPosition - (Vector3.down * 4);
		InvokeRepeating ("cameraSway", 0, 3);
	}

	void cameraSway(){
		fraction = 0;
		offset = originalPos + Random.insideUnitSphere * 50f;
	}

	void Update(){
		if (fraction < 4) {
			fraction += Time.deltaTime / speed;
			transform.position = Vector3.Lerp(camTransform.position, offset, fraction/10);
		}
		transform.LookAt (Vector3.zero);
	}
}
